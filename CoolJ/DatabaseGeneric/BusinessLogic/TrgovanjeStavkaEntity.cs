﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class TrgovanjeStavkaEntity
    {
        #region Custom Properties

        private decimal? _prometPromjenaPosto;
        public decimal? PrometPromjenaPosto 
        {
            get
            {
                if (null != this.TrgovanjeGlava.TrgovanjeGlavaPrethodniDan)
                {
                    TrgovanjeStavkaEntity trgovanjeStavkaPrethodniDan = 
                        this.TrgovanjeGlava.TrgovanjeGlavaPrethodniDan.TrgovanjeStavkaCollection.Where(ts =>
                            ts.ValutaId == this.ValutaId &&
                            ts.TrgovanjeVrstaId == this.TrgovanjeVrstaId).SingleOrDefault();

                    if (null != trgovanjeStavkaPrethodniDan &&
                        0 != trgovanjeStavkaPrethodniDan.Promet)
                    {
                        _prometPromjenaPosto = (this.Promet / trgovanjeStavkaPrethodniDan.Promet - 1) * 100;
                    }
                }
                
                return _prometPromjenaPosto;
            }
        }

        private decimal? _prometDodatakPromjenaPosto;
        public decimal? PrometDodatakPromjenaPosto
        {
            get
            {
                if (null != this.TrgovanjeGlava.TrgovanjeGlavaPrethodniDan)
                {
                    TrgovanjeStavkaEntity trgovanjeStavkaPrethodniDan =
                        this.TrgovanjeGlava.TrgovanjeGlavaPrethodniDan.TrgovanjeStavkaCollection.Where(ts =>
                            ts.ValutaId == this.ValutaId &&
                            ts.TrgovanjeVrstaId == this.TrgovanjeVrstaId).SingleOrDefault();

                    if (null != trgovanjeStavkaPrethodniDan &&
                        0 != trgovanjeStavkaPrethodniDan.PrometDodatak)
                    {
                        _prometDodatakPromjenaPosto = (this.PrometDodatak / trgovanjeStavkaPrethodniDan.PrometDodatak - 1) * 100;
                    }
                }

                return _prometDodatakPromjenaPosto;
            }
        }

        #endregion

        #region Static methods

        public static EntityCollection<TrgovanjeStavkaEntity> FetchTrgovanjeStavkaCollection(DataAccessAdapterBase adapter, 
            int godina, ValutaEnum? valutaEnum)
        {
            DateTime startDate = new DateTime(godina, 1, 1);
            DateTime endDate = startDate.AddYears(1);

            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.Relations.Add(TrgovanjeStavkaEntity.Relations.TrgovanjeGlavaEntityUsingTrgovanjeGlavaId);
            
            bucket.PredicateExpression.Add(PredicateHelper.FilterValidEntities(startDate, endDate, TrgovanjeGlavaFields.Datum));

            if (valutaEnum.HasValue)
            {
                bucket.PredicateExpression.Add(TrgovanjeStavkaFields.ValutaId == (long)valutaEnum);
            }

            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeStavkaEntity);
            prefetchPath.Add(TrgovanjeStavkaEntity.PrefetchPathTrgovanjeGlava);

            EntityCollection<TrgovanjeStavkaEntity> trgovanjeStavkaCollection = TrgovanjeStavkaEntity.FetchTrgovanjeStavkaCollection(adapter, bucket, prefetchPath);

            return trgovanjeStavkaCollection;
        }

        #endregion
    }
}
