using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Web.Mvc;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class RepoAukcijaViewModel
    {
        #region Constructor

        public RepoAukcijaViewModel(DataAccessAdapterBase adapter, DateTime? datumAukcije)
        {
            IEnumerable<DateTime> repoAukcijaDatumList = RepoAukcijaEntity.FetchRepoAukcijaDateCollection(adapter);

            if (datumAukcije.HasValue)
            {
                this.RepoAukcija = RepoAukcijaEntity.FetchRepoAukcija(adapter, null, datumAukcije.Value);
            }

            if (null == this.RepoAukcija)
            {
                this.RepoAukcija = RepoAukcijaEntity.FetchRepoAukcija(adapter, null, repoAukcijaDatumList.Max());
            }

            this.DatumAukcijeSelectList = new List<SelectListItem>();

            foreach (DateTime date in repoAukcijaDatumList)
            {
                SelectListItem selectListItem = new SelectListItem() 
                {
                    Value = date.ToShortDateString(),
                    Text = date.ToShortDateString(),
                    Selected = date == this.RepoAukcija.DatumAukcije
                };

                this.DatumAukcijeSelectList.Add(selectListItem);
            }
        }

        #endregion

        #region Properties

        public RepoAukcijaEntity RepoAukcija { get; set; }
        public List<SelectListItem> DatumAukcijeSelectList { get; set; }

        #endregion
    }
}