using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
    internal class EmailSender : IEmailSender
    {
        private string smtpHost;
        private int smtpPort;
        private string fromEmailAddress;

        public EmailSender(string smtpHost, int smtpPort, string fromEmailAddress)
        {
            smtpHost = smtpHost;
            this.smtpPort = smtpPort;
            this.fromEmailAddress = fromEmailAddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true

            };

            message.To.Add(new MailAddress(email));

            using(var client = new SmtpClient(smtpHost, smtpPort))
            {
                client.Send(message);

                return Task.CompletedTask;
            }
        }
    }
}