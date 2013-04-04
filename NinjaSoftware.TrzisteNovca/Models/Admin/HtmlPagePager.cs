using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Admin
{
    public class HtmlPagePager: PagerBase
    {
        public override string DefaultSortField
        {
            get { return HtmlPageFields.Name.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }

        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            this.DataSource = HtmlPageEntity.FetchHtmlPageCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = HtmlPageEntity.GetNumberOfEntities(adapter, null);
        }
    }
}