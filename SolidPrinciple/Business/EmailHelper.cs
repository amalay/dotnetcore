using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.Business
{
    class EmailHelper
    {
        private static readonly Lazy<EmailHelper> lazy = new Lazy<EmailHelper>(() => new EmailHelper());

        private EmailHelper() { }

        public static EmailHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public void SendEmail(User user)
        {
            if (!this.IsValidEmail(user.Email))
            {
                throw new Exception("Invalid email address!");
            }

            var fromEmail = "av@xyz.com";
            var toEmail = user.Email;
            var subject = "Registration";
            var mailBody = $"Welcome {user.Name}! Thanks for your registration.";
            var mailMessage = new MailMessage(fromEmail, toEmail, subject, mailBody);

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(mailMessage);
        }

        public bool IsValidEmail(string email)
        {
            bool isvaild = false;

            if (!string.IsNullOrEmpty(email) && email.Contains("@"))
            {
                isvaild = true;
            }

            return isvaild;
        }
    }
}
