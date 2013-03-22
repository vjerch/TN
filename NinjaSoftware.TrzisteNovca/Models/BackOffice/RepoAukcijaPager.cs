using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class RepoAukcijaPager : PagerBase
    {
        public override string DefaultSortField
        {
            get { return RepoAukcijaFields.DatumAukcije.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return false; }
        }

        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            IEnumerable<RepoAukcijaEntity> repoAukcijaCollection = 
                RepoAukcijaEntity.FetchRepoAukcijaCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);

            this.DataSource = repoAukcijaCollection;
            this.NoOfRecords = RepoAukcijaEntity.GetNumberOfEntities(adapter, null);
        }
    }
}