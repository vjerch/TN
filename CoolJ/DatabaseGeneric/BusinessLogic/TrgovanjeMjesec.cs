using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic
{
    public class TrgovanjeMjesec
    {
        public ValutaEnum Valuta { get; set; }
        public int Mjesec { get; set; }
        public decimal? Potraznja { get; set; }
        public decimal? Promet { get; set; }
        public decimal? KamatnaStopa { get; set; }

        public static List<TrgovanjeMjesec> GetTrgovanjeMjesecCollection(DataAccessAdapterBase adapter, int godina, ValutaEnum valutaEnum)
        {
            DateTime startDate = new DateTime(godina, 1, 1);
            DateTime endDate = new DateTime(godina, 12, 31);

            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.Relations.Add(TrgovanjeStavkaEntity.Relations.TrgovanjeGlavaEntityUsingTrgovanjeGlavaId);

            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum >= startDate);
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum <= endDate);

            EntityCollection<TrgovanjeStavkaEntity> trgovanjeStavkaCollection = TrgovanjeStavkaEntity.FetchTrgovanjeStavkaCollection(adapter, bucket, null);

            IEnumerable<long> valutaIdCollection = trgovanjeStavkaCollection.Select(ts => ts.ValutaId).Distinct();

            foreach (long valutaId in valutaIdCollection)
            { 
            
            }
        }
    }
}
