namespace BarberDemo.Extensions;

/// <summary>
/// Middleware yapılandırma extension methods
/// </summary>
public static class MiddlewareExtensions
{
    /// <summary>
    /// Uygulama middleware'lerini yapılandırır
    /// </summary>
    public static void ConfigureApplicationMiddleware(this WebApplication app)
    {
        // Static files - sıra önemli!
        app.UseDefaultFiles(); // UseStaticFiles'dan önce olmalı
        app.UseStaticFiles();

        // CORS
        app.UseCors();

        // Swagger - sadece development'ta
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Berber Demo API v1");
                c.RoutePrefix = "swagger";
            });
        }
    }
}
