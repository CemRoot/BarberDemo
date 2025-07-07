namespace BarberDemo.Models;

/// <summary>
/// Berber çalışma saatleri modeli
/// </summary>
public class WorkingHour
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
}

/// <summary>
/// Randevu modeli
/// </summary>
public class Appointment
{
    public int Id { get; set; }
    public string Customer { get; set; } = "";
    public string Email { get; set; } = "";
    public DateTime Date { get; set; }
    public bool ReminderSent { get; set; }
}

/// <summary>
/// Çalışma saati DTO'su
/// </summary>
public record WorkingHourDto(DayOfWeek Day, string Start, string End);

/// <summary>
/// Randevu DTO'su
/// </summary>
public record AppointmentDto(string Customer, string Email, DateTime Date);
