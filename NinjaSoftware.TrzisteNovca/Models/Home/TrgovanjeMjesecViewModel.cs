using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class TrgovanjeMjesecViewModel
    {
        #region Constructors

        public TrgovanjeMjesecViewModel(DataAccessAdapterBase adapter, int godina, int mjesec, ValutaEnum valutaEnum)
        {
            this.TrgovanjeGlavaCollection = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaCollection(adapter, godina, mjesec, valutaEnum).OrderBy(tg => tg.Datum);
            this.Godina = godina;
            this.Mjesec = mjesec;
            this.ValutaEnum = valutaEnum;
        }

        #endregion

        #region Properties

        public IEnumerable<TrgovanjeGlavaEntity> TrgovanjeGlavaCollection { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public ValutaEnum ValutaEnum { get; set; }

        #endregion
    }
}