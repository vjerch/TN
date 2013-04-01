using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class TrgovanjeMjesecRokViewModel
    {

        #region Constructors

        public TrgovanjeMjesecRokViewModel(DataAccessAdapterBase adapter, int godina, int mjesec)
        {
            this.TrgovanjeGlavaCollection = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaCollection(adapter, godina, mjesec, ValutaEnum.Kn).OrderBy(tg => tg.Datum);
            this.Godina = godina;
            this.Mjesec = mjesec;

            foreach (TrgovanjeGlavaEntity trgovanjeGlava in this.TrgovanjeGlavaCollection)
            {
                trgovanjeGlava.LoadTrgovanjeGlavaPrethodniDan(adapter);
            }

            this.TrgovanjeVrstaList = new List<TrgovanjeVrstaRoEntity>();
            foreach (TrgovanjeVrstaEnum trgovanjeVrstaEnum in Helper.TrgovanjeVrstaEnumArrayZaPrikaz)
            {
                TrgovanjeVrstaRoEntity trgovanjeVrsta = TrgovanjeVrstaRoEntity.FetchTrgovanjeVrstaRo(adapter, null, (long)trgovanjeVrstaEnum);
                this.TrgovanjeVrstaList.Add(trgovanjeVrsta);
            }
        }

        #endregion

        #region Properties

        public List<TrgovanjeVrstaRoEntity> TrgovanjeVrstaList { get; set; }
        public IEnumerable<TrgovanjeGlavaEntity> TrgovanjeGlavaCollection { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }

        #endregion
    }
}