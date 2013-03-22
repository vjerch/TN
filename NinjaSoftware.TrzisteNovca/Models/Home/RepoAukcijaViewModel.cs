using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class RepoAukcijaViewModel
    {
        #region Constructor

        public RepoAukcijaViewModel(DataAccessAdapterBase adapter, long repoAukcijaId)
        {
            this.RepoAukcija = RepoAukcijaEntity.FetchRepoAukcija(adapter, null, repoAukcijaId);
            this.DatumAukcijeList = RepoAukcijaEntity.FetchRepoAukcijaDateCollection(adapter).Select(d => d.ToShortDateString());
        }

        #endregion

        #region Properties

        public RepoAukcijaEntity RepoAukcija { get; set; }
        public IEnumerable<string> DatumAukcijeList { get; set; }

        #endregion
    }
}