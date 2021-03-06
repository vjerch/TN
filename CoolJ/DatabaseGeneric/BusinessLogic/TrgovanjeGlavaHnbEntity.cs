﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.Api.Core;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using NinjaSoftware.TrzisteNovca.CoolJ.FactoryClasses;
using NinjaSoftware.Api.CoolJ;
using SD.LLBLGen.Pro.LinqSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.Linq;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class TrgovanjeGlavaHnbEntity
    {
        #region Dynamic methods

        /// <summary>
        /// Ne radi rekurzivni save, već briše dane TrgovanjeStavka, pohranjuje TrgovanjeStavka jednu po jednu i na kraju pohranjuje TrgovanjeGlava.
        /// </summary>
        public void Save(DataAccessAdapterBase adapter,
            IEnumerable<TrgovanjeStavkaHnbEntity> trgovanjeStavkaHnbCollectionToDelete,
            bool refetchAfterSave)
        {
            if (null != trgovanjeStavkaHnbCollectionToDelete)
            {
                foreach (TrgovanjeStavkaHnbEntity trgovanjeStavkaHnb in trgovanjeStavkaHnbCollectionToDelete)
                {
                    trgovanjeStavkaHnb.Delete(adapter);
                }
            }

            this.Save(adapter, refetchAfterSave, false);

            foreach (TrgovanjeStavkaHnbEntity trgovanjeStavkaHnb in this.TrgovanjeStavkaHnbCollection)
            {
                trgovanjeStavkaHnb.Save(adapter, refetchAfterSave, false);
            }
        }

        public override void Save(DataAccessAdapterBase adapter, bool refetchAfterSave, bool recurse)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(TrgovanjeGlavaHnbFields.Datum == this.Datum.Date);
            bucket.PredicateExpression.Add(TrgovanjeGlavaHnbFields.TrgovanjeGlavaHnbId != this.TrgovanjeGlavaHnbId);

            int count = TrgovanjeGlavaHnbEntity.GetNumberOfEntities(adapter, bucket);
            if (count > 0)
            {
                throw new UserException(string.Format("Trgovanje za datum {0} je već uneseno.", this.Datum.ToShortDateString()));
            }

            base.Save(adapter, refetchAfterSave, recurse);
        }

        public override void Delete(DataAccessAdapterBase adapter)
        {
            EntityCollection<TrgovanjeStavkaHnbEntity> trgovanjeStavkaHnbCollection = this.TrgovanjeStavkaHnbCollection;

            if (null == trgovanjeStavkaHnbCollection ||
                0 == trgovanjeStavkaHnbCollection.Count)
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket(TrgovanjeStavkaHnbFields.TrgovanjeGlavaHnbId == this.TrgovanjeGlavaHnbId);
                trgovanjeStavkaHnbCollection = TrgovanjeStavkaHnbEntity.FetchTrgovanjeStavkaHnbCollection(adapter, bucket, null);
            }

            foreach (TrgovanjeStavkaHnbEntity trgovanjeStavkaHnb in trgovanjeStavkaHnbCollection)
            {
                trgovanjeStavkaHnb.Delete(adapter);
            }

            base.Delete(adapter);
        }

        public decimal IznosUkupno()
        {
            return this.TrgovanjeStavkaHnbCollection.Sum(ts => ts.IznosMilijuniKn);
        }

        public decimal? KamatnaStopaUkupno()
        {
            decimal iznosUkupno = this.IznosUkupno();

            if (0 == iznosUkupno)
            {
                return null;
            }
            else
            {
                return this.TrgovanjeStavkaHnbCollection.Sum(ts => ts.IznosMilijuniKn * ts.KamatnaStopa) / iznosUkupno;
            }
        }

        #endregion

        #region Static methods

        private static List<int> _godinaTrgovanjaCollection;
        public static List<int> GodinaTrgovanjaCollection(DataAccessAdapterBase adapter)
        {
            if (null == _godinaTrgovanjaCollection)
            {
                LoadTrgovanjeGodinaList(adapter);
            }

            return _godinaTrgovanjaCollection;
        }

        public static EntityCollection<TrgovanjeGlavaHnbEntity> FetchTrgovanjeGlavaHnbCollection(DataAccessAdapterBase adapter, int godina, int mjesec)
        {
            DateTime startDate = new DateTime(godina, mjesec, 1);
            DateTime endDate = startDate.AddMonths(1);

            return FetchTrgovanjeGlavaHnbCollection(adapter, startDate, endDate);
        }

        public static EntityCollection<TrgovanjeGlavaHnbEntity> FetchTrgovanjeGlavaHnbCollection(DataAccessAdapterBase adapter,
            DateTime startDate,
            DateTime endDate)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(PredicateHelper.FilterValidEntities(startDate, endDate, TrgovanjeGlavaHnbFields.Datum));

            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeGlavaHnbEntity);
            prefetchPath.Add(TrgovanjeGlavaHnbEntity.PrefetchPathTrgovanjeStavkaHnbCollection);

            return FetchTrgovanjeGlavaHnbCollection(adapter, bucket, prefetchPath);
        }

        #endregion

        #region private methods

        private static void LoadTrgovanjeGodinaList(DataAccessAdapterBase adapter)
        {
            EntityCollection<TrgovanjeGlavaHnbEntity> trgovanjeGlavaHnbCollection = new EntityCollection<TrgovanjeGlavaHnbEntity>(new TrgovanjeGlavaHnbEntityFactory());

            ExcludeIncludeFieldsList includeFieldList = new ExcludeIncludeFieldsList(false);
            includeFieldList.Add(TrgovanjeGlavaHnbFields.Datum);

            adapter.FetchEntityCollection(trgovanjeGlavaHnbCollection, includeFieldList, null);

            _godinaTrgovanjaCollection = trgovanjeGlavaHnbCollection.Select(tg => tg.Datum.Year).Distinct().ToList();

            _godinaTrgovanjaCollection.Sort();
        }

        #endregion
    }
}
