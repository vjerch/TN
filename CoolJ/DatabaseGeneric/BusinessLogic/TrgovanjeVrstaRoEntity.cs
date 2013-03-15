using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class TrgovanjeVrstaRoEntity
    {
        public static TrgovanjeVrstaRoEntity FetchTrgovanjeVrstaRo(DataAccessAdapterBase adapter, string sifraSlog)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(TrgovanjeVrstaRoFields.SifraSlog == sifraSlog);
            return FetchTrgovanjeVrstaRoCollection(adapter, bucket, null).SingleOrDefault();
        }
    }
}
