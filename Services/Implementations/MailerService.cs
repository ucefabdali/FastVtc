using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastVtc.Configurations;
using FastVtc.Services.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace FastVtc.Services.Implementations
{
    public class MailerService : IMailerService
    {
        private readonly MailerConfig _mailerConfig;

        public MailerService(IOptions<MailerConfig> mailerConfigOptions)
        {
            this._mailerConfig = mailerConfigOptions.Value;
        }

        public Task SendEmailAsync(string to, string subject, string message)
        {
            // create message
            var email = new MimeMessage {Sender = MailboxAddress.Parse(this._mailerConfig.SenderEmail)};
            if (!string.IsNullOrEmpty(this._mailerConfig.SenderName))
                email.Sender.Name = this._mailerConfig.SenderName;
            email.From.Add(email.Sender);
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = message };

            // send email
            using (var smtp = new SmtpClient())
            {
                try
                {
                    smtp.Connect(this._mailerConfig.HostAddress, this._mailerConfig.HostPort, SecureSocketOptions.Auto);
                    smtp.Authenticate(this._mailerConfig.HostUsername, "stfjvvhnvaxtkrte");
                    smtp.Send(email);
                    smtp.Disconnect(true);

                }
                catch (Exception e)
                {

                }
            }

            return Task.CompletedTask;

        }
    }
}
