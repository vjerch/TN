using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using System.Text;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class TrgovanjeDanViewModel
    {
        #region Constructors

        public TrgovanjeDanViewModel(DataAccessAdapterBase adapter, DateTime date)
        {
            this.TrgovanjeGlava = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaForGuiDisplay(adapter, date);

            IEnumerable<TrgovanjeGlavaEntity> trgovanjeGlavaCollection = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaCollection(adapter, date.AddDays(-15), date, ValutaEnum.Kn);

            StringBuilder charLinePonuda = new StringBuilder(512);
            charLinePonuda.Append("[");

            StringBuilder charLinePotraznja = new StringBuilder(512);
            charLinePotraznja.Append("[");

            StringBuilder charLinePromet = new StringBuilder(512);
            charLinePromet.Append("[");
        }

        #endregion

        #region Properties

        public TrgovanjeGlavaEntity TrgovanjeGlava { get; set; }
        public HtmlString ChartLinePonudaDataSource { get; set; }
        public HtmlString ChartLinePotraznjaDataSource { get; set; }
        public HtmlString ChartLinePrometDataSource { get; set; }

        #endregion
    }
}