using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class TrgovanjeGlavaPager : PagerBase
    {
        public override string DefaultSortField
        {
            get { return TrgovanjeGlavaFields.Datum.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return false; }
        }

        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            IEnumerable<TrgovanjeGlavaEntity> trgovanjeGlavaCollection = 
                TrgovanjeGlavaEntity.FetchTrgovanjeGlavaCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);

            this.DataSource = trgovanjeGlavaCollection;
            this.NoOfRecords = TrgovanjeGlavaEntity.GetNumberOfEntities(adapter, null);
        }
    }
}