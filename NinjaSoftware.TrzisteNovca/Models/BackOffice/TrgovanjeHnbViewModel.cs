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
    public class TrgovanjeHnbViewModel: IViewModel
    {
        #region Constructors

        public TrgovanjeHnbViewModel(DataAccessAdapterBase adapter, long? trgovanjeGlavaHnbId)
        {
            if (trgovanjeGlavaHnbId.HasValue && trgovanjeGlavaHnbId.Value > 0)
            {
                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.TrgovanjeGlavaHnbEntity);
                IPrefetchPathElement2 trgovanjeStavkaHnbPrefetchElement = prefetchPath.Add(TrgovanjeGlavaHnbEntity.PrefetchPathTrgovanjeStavkaHnbCollection);
                trgovanjeStavkaHnbPrefetchElement.SubPath.Add(TrgovanjeStavkaHnbEntity.PrefetchPathTrgovanjeVrsta);

                this.TrgovanjeGlavaHnb = TrgovanjeGlavaHnbEntity.FetchTrgovanjeGlavaHnb(adapter, prefetchPath, trgovanjeGlavaHnbId.Value);
                this.TrgovanjeStavkaHnbCollection = this.TrgovanjeGlavaHnb.TrgovanjeStavkaHnbCollection;
            }
            else
            {
                this.TrgovanjeGlavaHnb = new TrgovanjeGlavaHnbEntity();
                this.TrgovanjeGlavaHnb.Datum = DateTime.Now;
                this.TrgovanjeStavkaHnbCollection = new List<TrgovanjeStavkaHnbEntity>();
            }
        }

        #endregion

        #region Public methods

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.TrgovanjeVrstaCollection = TrgovanjeVrstaRoEntity.FetchTrgovanjeVrstaRoCollection(adapter, null, null).OrderBy(t => t.Name);
        }

        public void Save(DataAccessAdapterBase adapter)
        {
            this.TrgovanjeGlavaHnb.Save(adapter, this.TrgovanjeStavkaHnbCollectionToDelete, false);
        }

        public void UpdateModelFromJson(string trgovanjeGlavaHnbJson, string trgovanjeStavkaCollectionHnbJson)
        {
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            jsonSettings.Culture = currentCulture;

            TrgovanjeGlavaEntity trgovanjeGlavaDeserialized = JsonConvert.DeserializeObject<TrgovanjeGlavaEntity>(trgovanjeGlavaHnbJson, jsonSettings);
            this.TrgovanjeGlavaHnb.UpdateDataFromOtherObject(trgovanjeGlavaDeserialized, null, null);

            this.TrgovanjeStavkaHnbCollectionToDelete = this.TrgovanjeGlavaHnb.TrgovanjeStavkaHnbCollection.GetEntitiesNotIncludedInJson(trgovanjeStavkaCollectionHnbJson, jsonSettings);

            this.TrgovanjeGlavaHnb.TrgovanjeStavkaHnbCollection.UpdateEntityCollectionFromJson(trgovanjeStavkaCollectionHnbJson, TrgovanjeStavkaFields.TrgovanjeStavkaId, null, null, jsonSettings);
        }

        #endregion

        #region Properties

        public TrgovanjeGlavaHnbEntity TrgovanjeGlavaHnb { get; set; }
        public IEnumerable<TrgovanjeStavkaHnbEntity> TrgovanjeStavkaHnbCollection { get; set; }
        public List<TrgovanjeStavkaHnbEntity> TrgovanjeStavkaHnbCollectionToDelete { get; set; }
        public IEnumerable<TrgovanjeVrstaRoEntity> TrgovanjeVrstaCollection { get; set; }

        #endregion
    }
}