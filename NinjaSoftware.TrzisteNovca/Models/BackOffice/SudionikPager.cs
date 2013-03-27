using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class SudionikPager : PagerBase
    {
        public override string DefaultSortField
        {
            get { return SudionikFields.Naziv.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }

        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.SudionikEntity);
            prefetchPath.Add(SudionikEntity.PrefetchPathSudionikGrupa);

            IEnumerable<SudionikEntity> sudionikCollection = SudionikEntity.FetchSudionikCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);

            this.DataSource = sudionikCollection;
            this.NoOfRecords = SudionikEntity.GetNumberOfEntities(adapter, null);
        }
    }
}