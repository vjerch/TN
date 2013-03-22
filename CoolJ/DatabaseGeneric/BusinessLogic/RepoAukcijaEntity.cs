using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.Linq;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class RepoAukcijaEntity
    {
        public static IEnumerable<DateTime> FetchRepoAukcijaDateCollection(DataAccessAdapterBase adapter)
        {
            LinqMetaData linqMetaData = new LinqMetaData(adapter);
            return linqMetaData.RepoAukcija.OrderBy(ra => ra.DatumAukcije).Select(ra => ra.DatumAukcije);
        }
    }
}
