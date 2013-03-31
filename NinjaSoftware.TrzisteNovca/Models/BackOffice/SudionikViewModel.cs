using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models.BackOffice
{
    public class SudionikViewModel : IViewModel
    {
        public SudionikViewModel(DataAccessAdapterBase adapter, long? sudionikId)
        {
            if (sudionikId.HasValue)
            {
                this.Sudionik = SudionikEntity.FetchSudionik(adapter, null, sudionikId.Value);
            }
            else
            {
                this.Sudionik = new SudionikEntity();
            }
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.SudionikGrupaCollection = SudionikGrupaRoEntity.FetchSudionikGrupaRoCollection(adapter, null, null).OrderBy(sg => sg.Name);
        }

        public void Save(DataAccessAdapterBase adapter)
        {
            this.Sudionik.Save(adapter, false, false);
        }

        public SudionikEntity Sudionik { get; set; }
        public IEnumerable<SudionikGrupaRoEntity> SudionikGrupaCollection { get; set; }
    }
}