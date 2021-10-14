using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple
{
    public class RegistrationHelper
    {
        private static readonly Lazy<RegistrationHelper> lazy = new Lazy<RegistrationHelper>(() => new RegistrationHelper());

        private RegistrationHelper() { }

        public static RegistrationHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public void RegisterUser(User user)
        {

        }
    }
}
