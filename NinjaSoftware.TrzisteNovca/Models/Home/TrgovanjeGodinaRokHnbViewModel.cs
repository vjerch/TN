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
    public class TrgovanjeGodinaRokHnbViewModel : TrgovanjeGodinaRokViewModelBase
    {
        #region Constructors

        public TrgovanjeGodinaRokHnbViewModel(DataAccessAdapterBase adapter, int godina)
            :base(adapter, godina)
        {
            this.TrgovanjeMjesecRokHnbCollection = TrgovanjeMjesecRokHnb.GetTrgovanjeMjesecRokHnbCollection(adapter, godina, Helper.TrgovanjeVrstaEnumArrayZaPrikaz);
            this.GodinaSelectList = Helper.CreateTrgovanjeGlavaHnbGodinaSelectList(adapter, godina);
        }

        #endregion

        #region Properties

        public IEnumerable<TrgovanjeMjesecRokHnb> TrgovanjeMjesecRokHnbCollection { get; set; }

        #endregion
    }
}