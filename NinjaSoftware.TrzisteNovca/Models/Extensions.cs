using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace NinjaSoftware.TrzisteNovca.Models
{
    public static class Extensions
    {
        public static string ToStringInMilions(this decimal number, string format, string cultureName)
        {
            decimal milions = number / 1000000;
            return milions.ToString(format, new CultureInfo(cultureName));
        }

        public static string ToStringInMilions(this decimal number)
        {
            return number.ToStringInMilions("N2", "hr-HR");
        }
    }
}