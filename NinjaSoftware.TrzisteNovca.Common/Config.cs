using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace NinjaSoftware.TrzisteNovca.Common
{
    public static class Config
    {
        public static int PageSize()
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
        }

        public static string PagerPrefixText()
        {
            return ConfigurationManager.AppSettings["PagerPrefixText"];
        }

        public static string AukcijaTrezorskihZapisaFolderPath()
        {
            return ConfigurationManager.AppSettings["AukcijaTrezorskihZapisaFolderPath"];
        }

        public static string SettFolderPath()
        {
            return ConfigurationManager.AppSettings["SettFolderPath"];
        }
    }
}
