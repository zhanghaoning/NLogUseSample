using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogSample
{
    public class NLogTest
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();
        private Logger logger = LogManager.GetLogger("DefaultLog");
        private Logger errorLogger = LogManager.GetLogger("ErrorLog");
        public void TestNLog(string logContent="测试NLog日志记录")
        {
            logger.Info(logContent);
            logger.Error("Error");
        }
        public void TestException()
        {
            try
            {
                int a= 1;
                int b = 0;
                int c = a / b;
            }
            catch(Exception ex)
            {
                logger.Info(ex, "exception");
                errorLogger.Error(ex, "exception");
            }
        }
    }
}
