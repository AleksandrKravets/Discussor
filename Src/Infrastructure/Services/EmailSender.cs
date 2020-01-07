using Discussor.Infrastructure.Contracts;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DiscussorInfrastructure.Services
{
    internal class EmailSender : IEmailSender
    {
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;

        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (SmtpClient smtp = new SmtpClient(host, port))
            {
                smtp.Credentials = new NetworkCredential(userName, password);
                smtp.EnableSsl = enableSSL;
                await smtp.SendMailAsync(new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true });
            }
        }
    }
}
