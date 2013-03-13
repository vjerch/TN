using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.CoolJ;
using Newtonsoft.Json;
using System.Globalization;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class TrgovanjeViewModel: IViewModel
    {
        #region Constructors

        public TrgovanjeViewModel(DataAccessAdapterBase adapter, long? trgovanjeGlavaId)
        {
            if (trgovanjeGlavaId.HasValue && trgovanjeGlavaId.Value > 0)
            {
                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeGlavaEntity);
                prefetchPath.Add(TrgovanjeGlavaEntity.PrefetchPathTrgovanjeStavkaCollection).
                    SubPath.Add(TrgovanjeStavkaEntity.PrefetchPathRok);

                this.TrgovanjeGlava = TrgovanjeGlavaEntity.FetchTrgovanjeGlava(adapter, prefetchPath, trgovanjeGlavaId.Value);
                this.TrgovanjeStavkaCollection = this.TrgovanjeGlava.TrgovanjeStavkaCollection;
            }
            else
            {
                this.TrgovanjeGlava = new TrgovanjeGlavaEntity();
                this.TrgovanjeGlava.Datum = DateTime.Now;
                this.TrgovanjeGlava.Komentar = "Neki komentar";
                this.TrgovanjeStavkaCollection = new List<TrgovanjeStavkaEntity>();
            }
        }

        #endregion

        #region Public methods

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.RokCollection = RokEntity.FetchRokCollection(adapter, null, null).OrderBy(rok => rok.Naziv);
        }

        public void Save(DataAccessAdapterBase adapter)
        {
            this.TrgovanjeGlava.Save(adapter, this.TrgovanjeStavkaCollectionToDelete, false);
        }

        public void UpdateModelFromJson(string trgovanjeGlavaJson, string trgovanjeStavkaCollectionJson)
        {
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            jsonSettings.Culture = currentCulture;

            TrgovanjeGlavaEntity trgovanjeGlavaDeserialized = JsonConvert.DeserializeObject<TrgovanjeGlavaEntity>(trgovanjeGlavaJson, jsonSettings);
            this.TrgovanjeGlava.UpdateDataFromOtherObject(trgovanjeGlavaDeserialized, null, null);

            this.TrgovanjeStavkaCollectionToDelete = this.TrgovanjeGlava.TrgovanjeStavkaCollection.GetEntitiesNotIncludedInJson(trgovanjeStavkaCollectionJson, jsonSettings);

            this.TrgovanjeGlava.TrgovanjeStavkaCollection.UpdateEntityCollectionFromJson(trgovanjeStavkaCollectionJson, TrgovanjeStavkaFields.TrgovanjeStavkaId, null, null, jsonSettings);
        }

        #endregion

        #region Properties

        public TrgovanjeGlavaEntity TrgovanjeGlava { get; set; }
        public IEnumerable<TrgovanjeStavkaEntity> TrgovanjeStavkaCollection { get; set; }
        public IEnumerable<RokEntity> RokCollection { get; set; }
        public List<TrgovanjeStavkaEntity> TrgovanjeStavkaCollectionToDelete { get; set; }

        #endregion
    }
}