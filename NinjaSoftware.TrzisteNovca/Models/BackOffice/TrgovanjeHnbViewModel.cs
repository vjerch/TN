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
using System.Net;
using System.IO;
using HtmlAgilityPack;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;

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

            this.TrgovanjeGlavaHnb.TrgovanjeStavkaHnbCollection.UpdateEntityCollectionFromJson(trgovanjeStavkaCollectionHnbJson, TrgovanjeStavkaHnbFields.TrgovanjeStavkaHnbId, null, null, jsonSettings);
        }

        public static string DohvatiWebTrgovanjeGlavaHnb(DataAccessAdapterBase adapter)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.hnb.hr/monet/novcano-trziste/h-tablice-depozitni-novac.htm");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader resultStream = new StreamReader(responseStream);
            //string source = resultStream.ReadToEnd();

            HtmlDocument doc = new HtmlDocument();
            doc.Load(resultStream);

            string datumString = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tbody[1]/tr[2]/td[1]/font[1]/b[1]")[0].InnerText.Trim();
            datumString = datumString.Substring(datumString.Length - 11, 11);
            TrgovanjeGlavaHnbEntity trgovanjeGlavaHnb = new TrgovanjeGlavaHnbEntity();
            trgovanjeGlavaHnb.Datum = DateTime.Parse(datumString, CultureInfo.CurrentCulture);

            List<TrgovanjeStavkaHnbEntity> trgovanjeStavkaHnbList = new List<TrgovanjeStavkaHnbEntity>();

            for (int i = 2; i <= 10; i++)
            {
                string iznosString = doc.DocumentNode.SelectNodes(
                    string.Format("/html[1]/body[1]/table[1]/tbody[1]/tr[5]/td[{0}]", i))[0].InnerText.Trim();
                string kamatnaStopaString = doc.DocumentNode.SelectNodes(
                    string.Format("/html[1]/body[1]/table[2]/tbody[1]/tr[5]/td[{0}]", i))[0].InnerText.Trim();

                decimal iznos;
                decimal kamatnaStopa;

                if (decimal.TryParse(iznosString, out iznos) &&
                    decimal.TryParse(kamatnaStopaString, out kamatnaStopa))
                {
                    TrgovanjeStavkaHnbEntity trgovanjeStavkaHnb = new TrgovanjeStavkaHnbEntity();
                    trgovanjeStavkaHnb.IznosMilijuniKn = iznos;
                    trgovanjeStavkaHnb.KamatnaStopa = kamatnaStopa;

                    long trgovanjeVrstaId;
                    switch (i)
                    { 
                        case 2:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.Prekonocni;
                            break;
                        case 3:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.TomNext;
                            break;
                        case 4:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.SpotNext;
                            break;
                        case 5:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.Opoziv;
                            break;
                        case 6:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.RocniDepozit;
                            break;
                        case 7:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.JedanTjedan;
                            break;
                        case 8:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.DvaTjedna;
                            break;
                        case 9:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.JedanMjesec;
                            break;
                        case 10:
                            trgovanjeVrstaId = (long)TrgovanjeVrstaEnum.TriMjeseca;
                            break;
                        default:
                            throw new Exception("Enumerator error.");
                    }

                    trgovanjeStavkaHnb.TrgovanjeVrstaId = trgovanjeVrstaId;
                    trgovanjeStavkaHnb.TrgovanjeVrsta = TrgovanjeVrstaRoEntity.FetchTrgovanjeVrstaRo(adapter, null, trgovanjeVrstaId);
                    trgovanjeStavkaHnb.TrgovanjeGlavaHnb = trgovanjeGlavaHnb;

                    trgovanjeStavkaHnbList.Add(trgovanjeStavkaHnb);
                }
            }

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            jsonSettings.Culture = currentCulture;

            return JsonConvert.SerializeObject(trgovanjeStavkaHnbList, jsonSettings);
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