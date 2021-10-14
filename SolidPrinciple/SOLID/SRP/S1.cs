using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.S1
{
    public class UserRegistration
    {
        public void RegisterUser(string name, string email, string password)
        {
            
            if (!IsValidUserEntry(name) || IsValidUserEntry(email) 
                || IsValidUserEntry(password))
            {
                throw new Exception("Invalid input!");
            }

            //Register user
            var user = new User()
            {
                Name = name,
                Email = email,
                Password = password
            };

            //Send email
            this.SendEmail(user);
        }

        public bool IsValidUserEntry(string data)
        {
            bool isvaild = false;

            if (!string.IsNullOrEmpty(data))
            {
                isvaild = true;
            }

            return isvaild;
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
