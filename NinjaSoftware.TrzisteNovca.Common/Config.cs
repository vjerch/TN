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
    }
}
