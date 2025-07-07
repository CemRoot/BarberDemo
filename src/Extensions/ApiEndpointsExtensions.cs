using Microsoft.EntityFrameworkCore;
using BarberDemo.Data;
using BarberDemo.Models;
using BarberDemo.Services;

namespace BarberDemo.Extensions;

/// <summary>
/// API endpoint'lerini yapılandıran extension methods
/// </summary>
public static class ApiEndpointsExtensions
{
    /// <summary>
    /// Tüm API endpoint'lerini yapılandırır
    /// </summary>
    public static void MapApiEndpoints(this WebApplication app)
    {
        MapSystemEndpoints(app);
        MapAppointmentEndpoints(app);
        MapWorkingHoursEndpoints(app);
    }

    /// <summary>
    /// Sistem durumu endpoint'lerini tanımlar
    /// </summary>
    private static void MapSystemEndpoints(WebApplication app)
    {
        app.MapGet("/api/status", () => Results.Ok(new { 
            status = "OK", 
            timestamp = DateTime.UtcNow,
            version = "1.0.0"
        }))
        .WithTags("System")
        .WithSummary("Sistem durumu kontrolü");
    }

    /// <summary>
    /// Randevu ile ilgili endpoint'leri tanımlar
    /// </summary>
    private static void MapAppointmentEndpoints(WebApplication app)
    {
        // Get available appointment slots
        app.MapGet("/api/appointments/available", async (DateTime date, AppDb db) =>
        {
            var dayOfWeek = date.DayOfWeek;
            
            var workingHours = await db.WorkingHours
                .Where(wh => wh.Day == dayOfWeek)
                .ToListAsync();
            
            if (!workingHours.Any())
            {
                return Results.Ok(new { available = false, slots = new List<string>() });
            }
            
            var existingAppointments = await db.Appointments
                .Where(a => a.Date.Date == date.Date)
                .Select(a => a.Date.TimeOfDay)
                .ToListAsync();
            
            var availableSlots = new List<string>();
            foreach (var workingHour in workingHours)
            {
                for (var time = workingHour.Start; time < workingHour.End; time = time.Add(TimeSpan.FromHours(1)))
                {
                    if (!existingAppointments.Contains(time))
                    {
                        availableSlots.Add(time.ToString(@"hh\:mm"));
                    }
                }
            }
            
            return Results.Ok(new { available = true, slots = availableSlots });
        })
        .WithTags("Appointments")
        .WithSummary("Belirli bir tarih için uygun randevu saatlerini getirir");

        // Book an appointment
        app.MapPost("/api/appointments", async (AppointmentDto dto, AppDb db, IEmailService mail) =>
        {
            var when = DateTime.SpecifyKind(dto.Date, DateTimeKind.Utc);

            // Check if within working hours
            bool within = await db.WorkingHours.AnyAsync(h =>
                h.Day == when.DayOfWeek &&
                when.TimeOfDay >= h.Start &&
                when.TimeOfDay < h.End);

            if (!within)
                return Results.BadRequest("Seçilen saat çalışma saatleri dışındadır.");

            // Check for conflicts
            bool clash = await db.Appointments.AnyAsync(a => a.Date == when);
            if (clash)
                return Results.BadRequest("Bu saat için zaten randevu bulunmaktadır.");

            var appointment = new Appointment
            {
                Customer = dto.Customer,
                Email = dto.Email,
                Date = when
            };
            
            db.Appointments.Add(appointment);
            await db.SaveChangesAsync();

            // Send notification emails
            await mail.SendAsync("barber@example.com",
                                 "Yeni Randevu",
                                 $"{appointment.Customer} tarafından {appointment.Date:u} için randevu alındı.");
                                 
            await mail.SendAsync(appointment.Email,
                                 "Randevu Onayı",
                                 $"Sayın {appointment.Customer}, {appointment.Date:u} tarihindeki randevunuz onaylanmıştır.");

            return Results.Ok(appointment);
        })
        .WithTags("Appointments")
        .WithSummary("Yeni randevu oluşturur");
    }

    /// <summary>
    /// Çalışma saatleri ile ilgili endpoint'leri tanımlar
    /// </summary>
    private static void MapWorkingHoursEndpoints(WebApplication app)
    {
        app.MapPost("/api/hours", async (WorkingHourDto dto, AppDb db) =>
        {
            if (TimeSpan.Parse(dto.Start) >= TimeSpan.Parse(dto.End))
                return Results.BadRequest("Başlangıç saati bitiş saatinden önce olmalıdır.");

            var overlaps = await db.WorkingHours.AnyAsync(h =>
                h.Day == dto.Day &&
                (TimeSpan.Parse(dto.Start) < h.End &&
                 TimeSpan.Parse(dto.End) > h.Start));

            if (overlaps) 
                return Results.BadRequest("Çakışan çalışma saatleri mevcut.");

            var hour = new WorkingHour
            {
                Day = dto.Day,
                Start = TimeSpan.Parse(dto.Start),
                End = TimeSpan.Parse(dto.End)
            };
            
            db.WorkingHours.Add(hour);
            await db.SaveChangesAsync();
            
            return Results.Created($"/api/hours/{hour.Id}", hour);
        })
        .WithTags("Working Hours")
        .WithSummary("Yeni çalışma saati ekler");
    }
}
