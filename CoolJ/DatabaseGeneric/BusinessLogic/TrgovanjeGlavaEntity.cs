using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.Api.Core;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using NinjaSoftware.TrzisteNovca.CoolJ.FactoryClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class TrgovanjeGlavaEntity
    {
        #region Custom properties

        private TrgovanjeGlavaEntity _trgovanjeGlavaPrethodniDan;
        public TrgovanjeGlavaEntity TrgovanjeGlavaPrethodniDan 
        {
            get
            {
                return _trgovanjeGlavaPrethodniDan;
            }
        }

        private decimal? _ponuda;
        public decimal Ponuda
        {
            get
            {
                if (!_ponuda.HasValue)
                {
                    _ponuda = this.TrgovanjeStavkaCollection.Where(ts => (long)ValutaEnum.Kn == ts.ValutaId).Sum(ts => ts.Ponuda);
                }

                return _ponuda.Value;
            }
        }

        private decimal? _potraznja;
        public decimal Potraznja 
        {
            get
            {
                if (!_potraznja.HasValue)
                {
                    _potraznja = this.TrgovanjeStavkaCollection.Where(ts => (long)ValutaEnum.Kn == ts.ValutaId).Sum(ts => ts.Potraznja);
                }

                return _potraznja.Value;
            }
        }

        private decimal? _promet;
        public decimal Promet 
        {
            get
            {
                if (!_promet.HasValue)
                {
                    _promet = this.TrgovanjeStavkaCollection.Where(ts => (long)ValutaEnum.Kn == ts.ValutaId).Sum(ts => ts.Promet);
                }

                return _promet.Value;
            }
        }

        private decimal? _ponudaPromjenaPosto;
        public decimal? PonudaPromjenaPosto 
        {
            get
            {
                if (!_ponudaPromjenaPosto.HasValue && 
                    null != this.TrgovanjeGlavaPrethodniDan &&
                    0 != this.TrgovanjeGlavaPrethodniDan.Promet)
                {
                    _ponudaPromjenaPosto = (this.Ponuda /this.TrgovanjeGlavaPrethodniDan.Ponuda - 1) * 100;
                }

                return _ponudaPromjenaPosto;
            }
        }

        private decimal? _potraznjaPromjenaPosto;
        public decimal? PotraznjaPromjenaPosto 
        {
            get
            {
                if (!_potraznjaPromjenaPosto.HasValue && 
                    null != this.TrgovanjeGlavaPrethodniDan &&
                    0 != this.TrgovanjeGlavaPrethodniDan.Promet)
                {
                    _potraznjaPromjenaPosto = (this.Potraznja / this.TrgovanjeGlavaPrethodniDan.Potraznja - 1) * 100;
                }

                return _potraznjaPromjenaPosto;
            }
        }

        #endregion

        #region Dynamic methods

        /// <summary>
        /// Ne radi rekurzivni save, već briše dane TrgovanjeStavka, pohranjuje TrgovanjeStavka jednu po jednu i na kraju pohranjuje TrgovanjeGlava.
        /// </summary>
        public void Save(DataAccessAdapterBase adapter,
            IEnumerable<TrgovanjeStavkaEntity> trgovanjeStavkaCollectionToDelete,
            bool refetchAfterSave)
        {
            if (null != trgovanjeStavkaCollectionToDelete)
            {
                foreach (TrgovanjeStavkaEntity trgovanjeStavka in trgovanjeStavkaCollectionToDelete)
                {
                    trgovanjeStavka.Delete(adapter);
                }
            }

            this.Save(adapter, refetchAfterSave, false);

            foreach (TrgovanjeStavkaEntity trgovanjeStavka in this.TrgovanjeStavkaCollection)
            { 
                if (trgovanjeStavka.IsDirty)
                {
                    this.IsDirty = true;
                    trgovanjeStavka.Save(adapter, refetchAfterSave, false);
                }
            }
        }

        public override void Save(DataAccessAdapterBase adapter, bool refetchAfterSave, bool recurse)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum == this.Datum.Date);
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.TrgovanjeGlavaId != this.TrgovanjeGlavaId);

            int count = TrgovanjeGlavaEntity.GetNumberOfEntities(adapter, bucket);
            if (count > 0)
            {
                throw new UserException(string.Format("Trgovanje za datum {0} je već uneseno.", this.Datum.ToShortDateString()));
            }

            base.Save(adapter, refetchAfterSave, recurse);
        }

        public override void Delete(DataAccessAdapterBase adapter)
        {
            EntityCollection<TrgovanjeStavkaEntity> trgovanjeStavkaCollection = this.TrgovanjeStavkaCollection;

            if (null == trgovanjeStavkaCollection ||
                0 == trgovanjeStavkaCollection.Count)
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket(TrgovanjeStavkaFields.TrgovanjeGlavaId == this.TrgovanjeGlavaId);
                trgovanjeStavkaCollection = TrgovanjeStavkaEntity.FetchTrgovanjeStavkaCollection(adapter, bucket, null);
            }

            foreach (TrgovanjeStavkaEntity trgovanjeStavka in trgovanjeStavkaCollection)
            {
                trgovanjeStavka.Delete(adapter);
            }

            base.Delete(adapter);
        }

        public void LoadTrgovanjeGlavaPrethodniDan(DataAccessAdapterBase adapter)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum < this.Datum);

            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeGlavaEntity);
            prefetchPath.Add(TrgovanjeGlavaEntity.PrefetchPathTrgovanjeStavkaCollection);

            SortExpression sort = new SortExpression(TrgovanjeGlavaFields.Datum | SortOperator.Descending);

            EntityCollection<TrgovanjeGlavaEntity> trgovanjeGlavaCollection = new EntityCollection<TrgovanjeGlavaEntity>(new TrgovanjeGlavaEntityFactory());
            adapter.FetchEntityCollection(trgovanjeGlavaCollection, bucket, 1, sort, prefetchPath);

            _trgovanjeGlavaPrethodniDan = trgovanjeGlavaCollection.SingleOrDefault();
        }

        #endregion

        #region Public static methods

        public static TrgovanjeGlavaEntity FetchTrgovanjeGlavaForGuiDisplay(DataAccessAdapterBase adapter, DateTime date)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum <= date.Date);

            SortExpression sort = new SortExpression(TrgovanjeGlavaFields.Datum | SortOperator.Descending);

            EntityCollection<TrgovanjeGlavaEntity> trgovanjeGlavaCollection = new EntityCollection<TrgovanjeGlavaEntity>(new TrgovanjeGlavaEntityFactory());
            adapter.FetchEntityCollection(trgovanjeGlavaCollection, bucket, 1, sort);

            if (0 == trgovanjeGlavaCollection.Count)
            {
                sort = new SortExpression(TrgovanjeGlavaFields.Datum | SortOperator.Ascending);
                adapter.FetchEntityCollection(trgovanjeGlavaCollection, null, 1, sort);
            }

            return FetchTrgovanjeGlavaForGuiDisplay(adapter, trgovanjeGlavaCollection.Single().TrgovanjeGlavaId);
        }

        public static TrgovanjeGlavaEntity FetchTrgovanjeGlavaForGuiDisplay(DataAccessAdapterBase adapter, long trgovanjeGlavaId)
        { 
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeGlavaEntity);
            IPrefetchPathElement2 trgovanjeStavkaPrefetchElement = prefetchPath.Add(TrgovanjeGlavaEntity.PrefetchPathTrgovanjeStavkaCollection);
            trgovanjeStavkaPrefetchElement.SubPath.Add(TrgovanjeStavkaEntity.PrefetchPathValuta);
            trgovanjeStavkaPrefetchElement.SubPath.Add(TrgovanjeStavkaEntity.PrefetchPathTrgovanjeVrsta);

            TrgovanjeGlavaEntity trgovanjeGlava = TrgovanjeGlavaEntity.FetchTrgovanjeGlava(adapter, prefetchPath, trgovanjeGlavaId);
            trgovanjeGlava.LoadTrgovanjeGlavaPrethodniDan(adapter);

            return trgovanjeGlava;
        }

        public static TrgovanjeGlavaEntity LoadTrgovanjeFromSettFile(DataAccessAdapterBase adapter, string filePath, string fileName)
        {
            fileName = fileName.Replace(".txt", "");
            string[] fileNameParts = fileName.Split('_');

            ValidateSettFileName(fileNameParts);

            DateTime date = new DateTime(int.Parse(fileNameParts[1]), 
                int.Parse(fileNameParts[2]), 
                int.Parse(fileNameParts[3]));

            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(TrgovanjeGlavaFields.Datum == date);

            int count = TrgovanjeGlavaEntity.GetNumberOfEntities(adapter, bucket);

            if (count > 0)
            {
                throw new UserException(string.Format("Trgovanje za datum {0} je već uneseno.", date.ToShortDateString()));
            }

            TrgovanjeGlavaEntity trgovanjeGlava = new TrgovanjeGlavaEntity();
            trgovanjeGlava.Datum = date;

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        TrgovanjeStavkaEntity trgovanjeStavka = CreateTrgovanjeStavkaFromSettRecord(adapter, line);
                        trgovanjeGlava.TrgovanjeStavkaCollection.Add(trgovanjeStavka);
                    }
                }
            }
            finally
            {
                file.Close();
            }

            if (0 == trgovanjeGlava.TrgovanjeStavkaCollection.Count)
            {
                throw new UserException("Datoteka je prazna.");
            }

            trgovanjeGlava.Save(adapter, null, true);

            return trgovanjeGlava;
        }

        #endregion

        #region private static methods

        private static TrgovanjeStavkaEntity CreateTrgovanjeStavkaFromSettRecord(DataAccessAdapterBase adapter, string settRecord)
        {
            ValidateSettRecord(settRecord);

            string[] settRecordParts = settRecord.Split('#');

            TrgovanjeStavkaEntity trgovanjeStavka = new TrgovanjeStavkaEntity();
            trgovanjeStavka.Ponuda = decimal.Parse(settRecordParts[2]);
            trgovanjeStavka.PonudaDodatak = decimal.Parse(settRecordParts[3]);
            trgovanjeStavka.Potraznja = decimal.Parse(settRecordParts[4]);
            trgovanjeStavka.PotraznjaDodatak = decimal.Parse(settRecordParts[5]);
            trgovanjeStavka.Promet = decimal.Parse(settRecordParts[6]);
            trgovanjeStavka.PrometDodatak = decimal.Parse(settRecordParts[7]);

            string[] vrstaTrgovanjaValutaParts = settRecordParts[0].Split('-');
            string trgovanjeVrstaSifraSlog = string.Empty;
            bool isVrstaTrgovanjaValutaInvalid = false;

            if (vrstaTrgovanjaValutaParts.Length == 1)
            {
                trgovanjeStavka.ValutaId = (long)ValutaEnum.Kn;
                trgovanjeVrstaSifraSlog = vrstaTrgovanjaValutaParts[0].Trim();
            }
            else if (vrstaTrgovanjaValutaParts.Length == 2)
            {
                ValutaRoEntity valuta = ValutaRoEntity.FetchValutaRo(adapter, vrstaTrgovanjaValutaParts[0].Trim());
                if (null == valuta)
                {
                    isVrstaTrgovanjaValutaInvalid = true;
                }
                else
                {
                    trgovanjeStavka.ValutaId = valuta.ValutaId;
                    trgovanjeVrstaSifraSlog = vrstaTrgovanjaValutaParts[1].Trim();
                }
            }
            else
            {
                isVrstaTrgovanjaValutaInvalid = true;
            }

            TrgovanjeVrstaRoEntity trgovanjeVrsta = TrgovanjeVrstaRoEntity.FetchTrgovanjeVrstaRo(adapter, trgovanjeVrstaSifraSlog);
            if (null == trgovanjeVrsta)
            {
                isVrstaTrgovanjaValutaInvalid = true;
            }

            if (isVrstaTrgovanjaValutaInvalid)
            {
                throw new UserException(string.Format("Neispravnja vrsta trgovanja - '{0}'", settRecordParts[0]));
            }

            trgovanjeStavka.TrgovanjeVrstaId = trgovanjeVrsta.TrgovanjeVrstaId;

            return trgovanjeStavka;
        }

        private static void ValidateSettFileName(string[] fileNameParts)
        {
            string fileNameError = "Neispravan naziv datoteke.";
            
            if (4 != fileNameParts.Length)
            {
                throw new UserException(fileNameError);
            }

            if ("web" != fileNameParts[0].ToLower())
            {
                throw new UserException(fileNameError);
            }

            bool areDatePartsValid = true;
            for (int i = 1; i < 4; i++)
            {
                int foo;
                areDatePartsValid = int.TryParse(fileNameParts[i], out foo);
            }

            if (!areDatePartsValid)
            {
                throw new UserException(fileNameError);
            }
        }

        private static void ValidateSettRecord(string record)
        {
            string[] settRecordParts = record.Split('#');
            if (8 != settRecordParts.Length)
            {
                throw new UserException("Neispravan broj polja u slogu.");
            }

            bool areNumbersValid = true;
            for (int i = 2; i < 8; i++)
            {
                decimal foo;
                areNumbersValid = decimal.TryParse(settRecordParts[i], out foo);
            }

            if (!areNumbersValid)
            {
                throw new UserException("Brojčane vrijednosti u datoteci nisu ispravne.");
            }
        }

        #endregion
    }
}
