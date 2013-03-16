using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.Models;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

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
    }
}
