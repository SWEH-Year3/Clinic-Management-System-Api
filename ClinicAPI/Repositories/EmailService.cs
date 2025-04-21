using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
namespace ClinicAPI.Repositories
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("Clinic@gmail.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject=subject;
            email.Body=new TextPart("html") { Text = body };

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(configuration["EmailSetting:Host"],int.Parse( configuration["EmailSetting:Port"]), SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(configuration["EmailSetting:Username"], configuration["EmailSetting:Password"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
