using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.CoolJ;

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
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        public TrgovanjeGlavaEntity TrgovanjeGlava { get; set; }
        public IEnumerable<TrgovanjeStavkaEntity> TrgovanjeStavkaCollection { get; set; }
        public IEnumerable<RokEntity> RokCollection { get; set; }

        #endregion
    }
}