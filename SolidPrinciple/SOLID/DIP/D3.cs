using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.D3
{
    public interface ILogger
    {
        void LogMessage(string message);
    }

    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //Code to log message.  
        }
    }

    public class DbLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //code to log stack trace into a file.  
        }
    }    

    public class ExceptionLogger
    {
        private ILogger logger;

        public ExceptionLogger(ILogger aLogger)
        {
            this.logger = aLogger;
        }

        public void LogException(Exception ex)
        {            
            this.logger.LogMessage(ex.Message);
        }
    }

    public class Client
    {
        public void ExportData()
        {
            ILogger type = null;
            ExceptionLogger logger = null;

            try
            {
                //Code to export data.
            }
            catch (SqlException ex)
            {
                type = new DbLogger();
                logger = new ExceptionLogger(type);
                logger.LogException(ex);
            }
            catch (Exception ex)
            {
                type = new DbLogger();
                logger = new ExceptionLogger(type);
                logger.LogException(ex);
            }
        }
    }
}
