using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic
{
    public class TrgovanjeMjesecBase
    {
        public ValutaEnum Valuta { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
    }
}