using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class RokEntity
    {
        public static RokEntity FetchRok(DataAccessAdapterBase adapter, string sifra)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(RokFields.Sifra == sifra);
            return FetchRokCollection(adapter, bucket, null).SingleOrDefault();
        }
    }
}
