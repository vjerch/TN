using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class PrometGodina
    {
        #region Constructors

        public PrometGodina(DataAccessAdapterBase adapter, int? godina)
        {
            if (!godina.HasValue)
            {
                godina = DateTime.Now.Year;
            }


        }

        #endregion

        #region Properties



        #endregion
    }

    public class PrometGodinaRecord
    {
        public ValutaEnum Valuta { get; set; }
        public string Mjesec { get; set; }
        public decimal? Potraznja { get; set; }
        public decimal? Promet { get; set; }
        public decimal? KamatnaStopa { get; set; }
    }
}