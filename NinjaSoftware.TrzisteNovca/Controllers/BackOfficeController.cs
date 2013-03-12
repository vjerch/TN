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
using NinjaSoftware.Api.Core;

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

        [HttpGet]
        public ActionResult TrgovanjeEdit(long? trgovanjeGlavaId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                TrgovanjeViewModel viewModel = new TrgovanjeViewModel(adapter, trgovanjeGlavaId);
                viewModel.LoadViewSpecificData(adapter);
                return View(viewModel);
            }
        }

        [HttpPost]
        public ContentResult TrgovanjeSave(long trgovanjeGlavaId, string trgovanjeGlavaJson, string trgovanjeStavkaCollectionJson)
        {
            string returnJson;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            
            try
            {
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "TrgovanjeSave");
                TrgovanjeViewModel viewModel = new TrgovanjeViewModel(adapter, trgovanjeGlavaId);
                viewModel.Save(adapter);

                adapter.Commit();

                string url = this.Url.Action("TrgovanjeEdit", new { trgovanjeGlavaId = viewModel.TrgovanjeGlava.TrgovanjeGlavaId });
                returnJson = string.Format("{{ \"Url\": \"{0}\" }}", url);
            }
            catch (UserException ex)
            {
                returnJson = string.Format("{{ \"Error\": \"{0}\" }}", ex.Message);
                adapter.Rollback();
            }
            catch (Exception)
            {
                adapter.Rollback();
                throw;
            }
            finally
            {
                adapter.Dispose();
            }

            return new ContentResult() { Content = returnJson, ContentType = "application/json" };
        }
    }
}
