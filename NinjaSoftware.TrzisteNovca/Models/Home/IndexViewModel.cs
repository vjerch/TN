using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class IndexViewModel
    {
        #region Constructor

        public IndexViewModel(DateTime datum)
        {
            FakeData();
        }

        #endregion

        #region Private methods

        private void FakeData()
        {
            this.PonudaUMilKn = 27.234M;
            this.PonudaPromjenaPosto = -35.54M;
            this.PotraznjaUMilKn = 150.2345M;
            this.PotraznjaPromjenaPosto = -44.55M;

            this.PrometList = new List<Promet>();

            Promet prometPrekonocni = new Promet() 
            {
                Naziv = "prekonoćni",
                PrometUMilKn = 20.34M,
                PrometPromjenaPosto = 22.88M,
                KamatnaStopaPosto = 1.23M,
                KamatnaStopaPromjenaPosto = 4.44M
            };
            this.PrometList.Add(prometPrekonocni);

            Promet prometTjedan = new Promet()
            {
                Naziv = "tjedan",
                PrometUMilKn = 7.34M,
                PrometPromjenaPosto = 9.88M,
                KamatnaStopaPosto = 10.23M,
                KamatnaStopaPromjenaPosto = 9.44M
            };
            this.PrometList.Add(prometTjedan);

            Promet prometViseOdTriMjeseca = new Promet()
            {
                Naziv = "tjedan",
                PrometUMilKn = 44.34M,
                PrometPromjenaPosto = 22.88M,
                KamatnaStopaPosto = 11.23M,
                KamatnaStopaPromjenaPosto = 0.44M
            };
            this.PrometList.Add(prometViseOdTriMjeseca);

            this.PozajmicaDevizaList = new List<PozajmicaDeviza>();
            PozajmicaDeviza pozajmicaDeviza = new PozajmicaDeviza() 
            {
                Valuta = "Eur",
                PrometUMil = 1.11M,
                KamatnaStopa = 2.22M
            };
            this.PozajmicaDevizaList.Add(pozajmicaDeviza);
        }

        #endregion

        #region Properties

        public decimal PonudaUMilKn { get; set; }
        public decimal PonudaPromjenaPosto { get; set; }
        public decimal PotraznjaUMilKn { get; set; }
        public decimal PotraznjaPromjenaPosto { get; set; }
        public List<Promet> PrometList { get; set; }
        public List<PozajmicaDeviza> PozajmicaDevizaList { get; set; }

        #endregion
    }

    public class Promet
    {
        public string Naziv { get; set; }
        public decimal PrometUMilKn { get; set; }
        public decimal PrometPromjenaPosto { get; set; }
        public decimal KamatnaStopaPosto { get; set; }
        public decimal KamatnaStopaPromjenaPosto { get; set; }
    }

    public class PozajmicaDeviza
    {
        public string Valuta { get; set; }
        public decimal PrometUMil { get; set; }
        public decimal KamatnaStopa { get; set; }
    }
}