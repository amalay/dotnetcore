using Amalay.SolidPrinciple.D3;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.D4
{
    public class EventLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //code to log stack trace into a file.  
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
            catch (System.IO.IOException ex)
            {
                type = new EventLogger();
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
