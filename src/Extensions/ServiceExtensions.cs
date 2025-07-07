using Microsoft.EntityFrameworkCore;
using BarberDemo.Data;
using BarberDemo.Services;

namespace BarberDemo.Extensions;

/// <summary>
/// Servis yapılandırma extension methods
/// </summary>
public static class ServiceExtensions
{
    /// <summary>
    /// Tüm uygulama servislerini yapılandırır
    /// </summary>
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        // API Documentation
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new() { 
                Title = "Berber Demo API", 
                Version = "v1",
                Description = "Modern berber randevu sistemi API'si"
            });
        });

        // Database
        services.AddDbContext<AppDb>(opt => opt.UseInMemoryDatabase("BarberDemo"));
        
        // Custom Services
        services.AddScoped<IEmailService, EmailService>();
        services.AddHostedService<ReminderService>();

        // CORS
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });
    }
}
