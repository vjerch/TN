using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class TrgovanjeGlavaHnbPager : PagerBase
    {
        public override string DefaultSortField
        {
            get { return TrgovanjeGlavaHnbFields.Datum.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return false; }
        }

        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            IEnumerable<TrgovanjeGlavaHnbEntity> trgovanjeGlavaHnbCollection = 
                TrgovanjeGlavaHnbEntity.FetchTrgovanjeGlavaHnbCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);

            this.DataSource = trgovanjeGlavaHnbCollection;
            this.NoOfRecords = TrgovanjeGlavaHnbEntity.GetNumberOfEntities(adapter, null);
        }
    }
}