using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class ValutaRoEntity
    {
        public static ValutaRoEntity FetchValutaRo(DataAccessAdapterBase adapter, string sifraSlog)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(ValutaRoFields.SifraSlog == sifraSlog);
            return FetchValutaRoCollection(adapter, bucket, null).SingleOrDefault();
        }
    }
}
