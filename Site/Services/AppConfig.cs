using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Site.Services
{
    public static class AppConfig
    {
        public static string Email { get { return ConfigurationManager.AppSettings["Email"].ToString(); } }
        public static string Phone { get { return ConfigurationManager.AppSettings["Phone"].ToString(); } }
    }
}