using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.TrzisteNovca.Models;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using NinjaSoftware.TrzisteNovca.Models.BackOffice;
using NinjaSoftware.TrzisteNovca.Common;

namespace NinjaSoftware.TrzisteNovca.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class BackOfficeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TrgovanjeGlavaList(int? pageNumber, string sortField, bool? isSortAscending)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeGlavaPager trgovanjeGlavaPager = new TrgovanjeGlavaPager();
                trgovanjeGlavaPager.LoadData(adapter, pageNumber, Config.PageSize(), sortField, isSortAscending);
                return View(trgovanjeGlavaPager);
            }
        }
    }
}
