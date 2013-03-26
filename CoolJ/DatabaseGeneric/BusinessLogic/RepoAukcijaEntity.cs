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
        private static List<DateTime> _repoAukcijaDateCollection;

        public static List<DateTime> FetchRepoAukcijaDateCollection(DataAccessAdapterBase adapter)
        {
            if (null == _repoAukcijaDateCollection)
            {
                LinqMetaData linqMetaData = new LinqMetaData(adapter);
                _repoAukcijaDateCollection = linqMetaData.RepoAukcija.OrderBy(ra => ra.DatumAukcije).Select(ra => ra.DatumAukcije).ToList();
            }

            return _repoAukcijaDateCollection;
        }

        public static RepoAukcijaEntity FetchRepoAukcija(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, DateTime datumAukcije)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(RepoAukcijaFields.DatumAukcije == datumAukcije);

            return FetchRepoAukcijaCollection(adapter, bucket, prefetchPath).SingleOrDefault();
        }
    }
}
