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
            LoadChartData(adapter, this.TrgovanjeGlava.Datum);
        }

        #endregion

        #region PrivateMethods

        private void LoadChartData(DataAccessAdapterBase adapter, DateTime date)
        {
            IEnumerable<TrgovanjeGlavaEntity> trgovanjeGlavaCollection = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaCollection(adapter, date.AddDays(-14), date.AddDays(1), ValutaEnum.Kn);

            StringBuilder chartLinePonuda = new StringBuilder(512);
            chartLinePonuda.Append("[");

            StringBuilder chartLinePotraznja = new StringBuilder(512);
            chartLinePotraznja.Append("[");

            StringBuilder chartLinePromet = new StringBuilder(512);
            chartLinePromet.Append("[");

            foreach (TrgovanjeGlavaEntity trgovanjeGlava in trgovanjeGlavaCollection)
            {
                string dateString = trgovanjeGlava.Datum.ToString("yyyy-MM-dd");
                chartLinePonuda.Append(string.Format("['{0}', {1}],", dateString, trgovanjeGlava.Ponuda(ValutaEnum.Kn).ToStringInMilions("F", "en")));
                chartLinePotraznja.Append(string.Format("['{0}', {1}],", dateString, trgovanjeGlava.Potraznja(ValutaEnum.Kn).ToStringInMilions("F", "en")));
                chartLinePromet.Append(string.Format("['{0}', {1}],", dateString, trgovanjeGlava.Promet(ValutaEnum.Kn).ToStringInMilions("F", "en")));
            }

            chartLinePonuda.Append("]");
            chartLinePotraznja.Append("]");
            chartLinePromet.Append("]");

            this.ChartLinePonudaDataSource = new HtmlString(chartLinePonuda.ToString());
            this.ChartLinePotraznjaDataSource = new HtmlString(chartLinePotraznja.ToString());
            this.ChartLinePrometDataSource = new HtmlString(chartLinePromet.ToString());
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