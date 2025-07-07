using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace BarberDemo.Services;

/// <summary>
/// E-mail gönderme servisi arayüzü
/// </summary>
public interface IEmailService
{
    Task SendAsync(string to, string subject, string body);
}

/// <summary>
/// E-mail gönderme servisi implementasyonu
/// </summary>
public class EmailService(IConfiguration cfg, ILogger<EmailService> log) : IEmailService
{
    public async Task SendAsync(string to, string subject, string body)
    {
        var mode = cfg["Mail:Mode"] ?? "console";

        // Console mode — demo default
        if (mode.Equals("console", StringComparison.OrdinalIgnoreCase))
        {
            log.LogInformation("📧 MAIL → {To} | {Subject}", to, subject);
            return;
        }

        // SMTP mode via MailKit
        await SendViaSmtpAsync(to, subject, body);
    }

    private async Task SendViaSmtpAsync(string to, string subject, string body)
    {
        var msg = new MimeMessage
        {
            Subject = subject,
            Body = new TextPart(TextFormat.Plain) { Text = body }
        };
        
        msg.From.Add(MailboxAddress.Parse(cfg["Mail:Smtp:From"]!));
        msg.To.Add(MailboxAddress.Parse(to));

        using var smtp = new SmtpClient();
        await smtp.ConnectAsync(
            cfg["Mail:Smtp:Host"],
            int.Parse(cfg["Mail:Smtp:Port"]!),
            SecureSocketOptions.StartTls);
            
        await smtp.AuthenticateAsync(
            cfg["Mail:Smtp:User"],
            cfg["Mail:Smtp:Pass"]);
            
        await smtp.SendAsync(msg);
        await smtp.DisconnectAsync(true);
    }
}
