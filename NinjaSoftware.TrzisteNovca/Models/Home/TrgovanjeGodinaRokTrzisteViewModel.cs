using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using System.Web.Mvc;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class TrgovanjeGodinaRokTrzisteViewModel : TrgovanjeGodinaRokViewModelBase
    {
        #region Constructors

        public TrgovanjeGodinaRokTrzisteViewModel(DataAccessAdapterBase adapter, int godina)
            :base(adapter, godina)
        {
            this.TrgovanjeMjesecRokCollection = TrgovanjeMjesecRok.GetTrgovanjeMjesecRokCollection(adapter, godina, Helper.TrgovanjeVrstaEnumArrayZaPrikaz);
            this.GodinaSelectList = Helper.CreateTrgovanjeGlavaGodinaSelectList(adapter, godina);
        }

        #endregion

        #region Properties

        public IEnumerable<TrgovanjeMjesecRok> TrgovanjeMjesecRokCollection { get; set; }

        #endregion
    }
}