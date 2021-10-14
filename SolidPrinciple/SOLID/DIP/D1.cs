using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.D1
{
    public class FileLogger
    {
        public void LogMessage(string message)
        {
            //Code to log message.  
        }
    }

    public class ExceptionLogger
    {
        public void LogIntoFile(Exception ex)
        {
            var logger = new FileLogger();
            logger.LogMessage(ex.Message);
        }
    }

    public class Client
    {
        public void ExportData()
        {
            var logger = new ExceptionLogger();

            try
            {
                //Code to export data.  
            }
            catch (Exception ex)
            {                
                logger.LogIntoFile(ex);
            }
        }
    }
}
