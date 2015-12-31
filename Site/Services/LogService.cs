using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Services
{
    public static class LogService    
    {
        private static readonly ILog Log = LogManager.GetLogger("LogService");

        static LogService()
        {
            BasicConfigurator.Configure();
            XmlConfigurator.Configure();
        }

        public static void Info(string info)
        {
            Log.Info(info);
        }

        public static void Error(string info)
        {
            Log.Error(info);
        }
    }
}