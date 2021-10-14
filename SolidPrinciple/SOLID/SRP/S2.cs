using Amalay.SolidPrinciple.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.S2
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
            EmailHelper.Instance.SendEmail(user);
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
    }
}
