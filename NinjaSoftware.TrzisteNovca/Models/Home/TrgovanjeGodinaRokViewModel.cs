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
    public class TrgovanjeGodinaRokViewModel
    {
        #region Constructors

        public TrgovanjeGodinaRokViewModel(DataAccessAdapterBase adapter, int godina)
        {
            this.Godina = godina;

            this.TrgovanjeMjesecRokCollection = TrgovanjeMjesecRok.GetTrgovanjeMjesecRokCollection(adapter, godina, Helper.TrgovanjeVrstaEnumArrayZaPrikaz);

            this.TrgovanjeVrstaList = new List<TrgovanjeVrstaRoEntity>();
            foreach (TrgovanjeVrstaEnum trgovanjeVrstaEnum in Helper.TrgovanjeVrstaEnumArrayZaPrikaz)
            {
                TrgovanjeVrstaRoEntity trgovanjeVrsta = TrgovanjeVrstaRoEntity.FetchTrgovanjeVrstaRo(adapter, null, (long)trgovanjeVrstaEnum);
                this.TrgovanjeVrstaList.Add(trgovanjeVrsta);
            }

            this.GodinaSelectList = Helper.CreateGodinaSelectList(adapter, godina);
        }

        #endregion

        #region Properties

        public List<TrgovanjeVrstaRoEntity> TrgovanjeVrstaList { get; set; }
        public IEnumerable<TrgovanjeMjesecRok> TrgovanjeMjesecRokCollection { get; set; }
        public int Godina { get; set; }
        public List<SelectListItem> GodinaSelectList { get; set; }

        #endregion
    }
}