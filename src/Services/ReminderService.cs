using Microsoft.EntityFrameworkCore;
using BarberDemo.Data;

namespace BarberDemo.Services;

/// <summary>
/// Randevu hatırlatma background servisi
/// </summary>
public class ReminderService(IServiceProvider sp, ILogger<ReminderService> log) : BackgroundService
{
    private readonly TimeSpan _checkInterval = TimeSpan.FromMinutes(5); // 5 dakikada bir kontrol

    protected override async Task ExecuteAsync(CancellationToken stop)
    {
        log.LogInformation("🔔 Reminder service started");
        
        var timer = new PeriodicTimer(_checkInterval);
        
        while (await timer.WaitForNextTickAsync(stop))
        {
            try
            {
                await ProcessRemindersAsync(stop);
            }
            catch (Exception ex)
            {
                log.LogError(ex, "❌ Error processing reminders");
            }
        }
    }

    private async Task ProcessRemindersAsync(CancellationToken cancellationToken)
    {
        using var scope = sp.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDb>();
        var mail = scope.ServiceProvider.GetRequiredService<IEmailService>();

        var now = DateTime.UtcNow;
        var reminderWindow = now.AddHours(24); // 24 saat öncesi hatırlatma

        var pendingReminders = await db.Appointments
            .Where(a => !a.ReminderSent &&
                       a.Date >= now &&
                       a.Date <= reminderWindow)
            .ToListAsync(cancellationToken);

        foreach (var appointment in pendingReminders)
        {
            await SendReminderAsync(mail, appointment);
            appointment.ReminderSent = true;
            
            log.LogInformation("✅ Reminder sent for appointment {Id} - {Customer}", 
                appointment.Id, appointment.Customer);
        }

        if (pendingReminders.Count > 0)
        {
            await db.SaveChangesAsync(cancellationToken);
            log.LogInformation("📝 Processed {Count} reminders", pendingReminders.Count);
        }
    }

    private static async Task SendReminderAsync(IEmailService emailService, Models.Appointment appointment)
    {
        var subject = "🔔 Randevu Hatırlatması";
        var body = $"""
            Merhaba {appointment.Customer},
            
            Yarın {appointment.Date:dd.MM.yyyy HH:mm} tarihinde randevunuz bulunmaktadır.
            
            Randevu detayları:
            📅 Tarih: {appointment.Date:dd MMMM yyyy}
            🕐 Saat: {appointment.Date:HH:mm}
            
            Randevunuzu kaçırmayın!
            
            İyi günler,
            Berber Demo Ekibi
            """;

        await emailService.SendAsync(appointment.Email, subject, body);
    }
}
