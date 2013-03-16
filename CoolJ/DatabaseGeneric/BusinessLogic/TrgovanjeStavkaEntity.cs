using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;

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
    }
}
