using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class HtmlPageEntity
    {
        public static HtmlPageEntity FetchHtmlPage(DataAccessAdapterBase adapter, long sistemskaInstancaPodatakaId)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(HtmlPageFields.SistemskaInstancaPodatakaId == sistemskaInstancaPodatakaId);
            return FetchHtmlPageCollection(adapter, bucket, null).SingleOrDefault();
        }
    }
}
