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

                TrgovanjeGlavaEntity trgovanjeGlava = TrgovanjeGlavaEntity.FetchTrgovanjeGlavaForGuiDisplay(adapter, date.Value);

                return View(trgovanjeGlava);
            }       
        }

        public ActionResult TrgovanjeGodina(int godina)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                List<TrgovanjeMjesec> trgovanjeMjesecList = 
                    NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic.TrgovanjeMjesec.GetTrgovanjeMjesecCollection(adapter, godina);
                return View(trgovanjeMjesecList);
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
    }
}
