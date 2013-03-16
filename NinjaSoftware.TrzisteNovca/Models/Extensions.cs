using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjaSoftware.TrzisteNovca.Models
{
    public static class Extensions
    {
        public static string ToStringInMilions(this decimal number)
        {
            decimal milions = number / 1000000;
            return milions.ToString("N2");
        }
    }
}