using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class SudionikEntity
    {
        public static EntityCollection<SudionikEntity> FetchSudionikCollection(DataAccessAdapterBase adapter, long sudionikGrupaId)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(SudionikFields.SudionikGrupaId == sudionikGrupaId);
            return FetchSudionikCollection(adapter, bucket, null);
        }
    }
}
