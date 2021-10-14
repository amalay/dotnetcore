using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.D2
{
    public class FileLogger
    {
        public void LogMessage(string message)
        {
            //Code to log message.  
        }
    }

    public class DbLogger
    {
        public void LogMessage(string message)
        {
            //code to log stack trace into a file.  
        }
    }
    
    public class ExceptionLogger
    {
        public void LogIntoFile(Exception ex)
        {
            var logger = new FileLogger();
            logger.LogMessage(ex.Message);
        }

        public void LogIntoDataBase(Exception ex)
        {
            var logger = new DbLogger();
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
            catch (SqlException ex)
            {
                logger.LogIntoDataBase(ex);
            }
            catch (Exception ex)
            {
                logger.LogIntoFile(ex);
            }
        }
    }
}
