using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.TrzisteNovca.Models.Home;

namespace NinjaSoftware.TrzisteNovca.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel(DateTime.Now);
            return View(viewModel);
        }

    }
}
