using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.Api.Core;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
    public partial class TrgovanjeGlavaEntity
    {
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
                        ValidateSettRecord(line);

                        string[] settRecordParts = line.Split('#');

                        RokEntity rok = RokEntity.FetchRok(adapter, settRecordParts[0]);

                        if (null == rok)
                        {
                            throw new UserException(string.Format("Rok '{0}' - '{1}' nije unesen.", settRecordParts[0], settRecordParts[1]));
                        }

                        TrgovanjeStavkaEntity trgovanjeStavka = new TrgovanjeStavkaEntity();
                        trgovanjeStavka.RokId = rok.RokId;
                        trgovanjeStavka.Ponuda = decimal.Parse(settRecordParts[2]);
                        trgovanjeStavka.PonudaDodatak = decimal.Parse(settRecordParts[3]);
                        trgovanjeStavka.Potraznja = decimal.Parse(settRecordParts[4]);
                        trgovanjeStavka.PotraznjaDodatak = decimal.Parse(settRecordParts[5]);
                        trgovanjeStavka.Promet = decimal.Parse(settRecordParts[6]);
                        trgovanjeStavka.PrometDodatak = decimal.Parse(settRecordParts[7]);

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
    }
}
