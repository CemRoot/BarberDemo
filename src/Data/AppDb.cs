using Microsoft.EntityFrameworkCore;
using BarberDemo.Models;

namespace BarberDemo.Data;

/// <summary>
/// Entity Framework DbContext
/// </summary>
public class AppDb(DbContextOptions<AppDb> opts) : DbContext(opts)
{
    public DbSet<WorkingHour> WorkingHours => Set<WorkingHour>();
    public DbSet<Appointment> Appointments => Set<Appointment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Working Hours configuration
        modelBuilder.Entity<WorkingHour>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Day).IsRequired();
            entity.Property(e => e.Start).IsRequired();
            entity.Property(e => e.End).IsRequired();
        });

        // Appointments configuration
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Customer).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
            entity.Property(e => e.Date).IsRequired();
            entity.Property(e => e.ReminderSent);
        });
    }
}
