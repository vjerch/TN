using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.Models;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic;
using NinjaSoftware.TrzisteNovca.Models.Home;

namespace NinjaSoftware.TrzisteNovca.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(DateTime? date)
        {
            return RedirectToAction("TrgovanjeDan");
        }

        public ActionResult TrgovanjeDan(DateTime? date)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                if (!date.HasValue)
                {
                    date = DateTime.Now.Date;
                }

                TrgovanjeDanViewModel trgovanjeDanViewModel = new TrgovanjeDanViewModel(adapter, date.Value);
                return View(trgovanjeDanViewModel);
            }       
        }

        public ActionResult TrgovanjeGodina(int godina)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeGodinaViewModel trgovanjeGodinaViewModel = new TrgovanjeGodinaViewModel(adapter, godina);
                return View(trgovanjeGodinaViewModel);
            }
        }

        public ActionResult TrgovanjeMjesec(int godina, int mjesec, ValutaEnum valutaEnum)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeMjesecViewModel trgovanjeMjesecViewModel = new TrgovanjeMjesecViewModel(adapter, godina, mjesec, valutaEnum);
                return View(trgovanjeMjesecViewModel);
            }        
        }

        public ActionResult TrgovanjeGodinaRok(int godina)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeGodinaRokViewModel trgovanjeGodinaRokViewModel = new TrgovanjeGodinaRokViewModel(adapter, godina);
                return View(trgovanjeGodinaRokViewModel);
            }  
        }

        public ActionResult TrgovanjeMjesecRok(int godina, int mjesec)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeMjesecRokViewModel trgovanjeMjesecRokViewModel = new TrgovanjeMjesecRokViewModel(adapter, godina, mjesec);
                return View(trgovanjeMjesecRokViewModel);
            }
        }

    }
}
