using Microsoft.EntityFrameworkCore;
using BarberDemo.Data;
using BarberDemo.Models;

namespace BarberDemo.Extensions;

/// <summary>
/// Veritabanı başlangıç verilerini yöneten extension methods
/// </summary>
public static class DatabaseExtensions
{
    /// <summary>
    /// Demo verileri yükler
    /// </summary>
    public static async Task SeedDataAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDb>();
        
        if (!await db.WorkingHours.AnyAsync())
        {
            db.WorkingHours.AddRange(
                new WorkingHour { Day = DayOfWeek.Monday, Start = new(10, 0, 0), End = new(18, 0, 0) },
                new WorkingHour { Day = DayOfWeek.Tuesday, Start = new(10, 0, 0), End = new(18, 0, 0) },
                new WorkingHour { Day = DayOfWeek.Wednesday, Start = new(10, 0, 0), End = new(18, 0, 0) },
                new WorkingHour { Day = DayOfWeek.Thursday, Start = new(10, 0, 0), End = new(18, 0, 0) },
                new WorkingHour { Day = DayOfWeek.Friday, Start = new(10, 0, 0), End = new(18, 0, 0) },
                new WorkingHour { Day = DayOfWeek.Saturday, Start = new(10, 0, 0), End = new(16, 0, 0) }
            );
            await db.SaveChangesAsync();
        }
    }
}
