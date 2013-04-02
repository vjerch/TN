using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.Models;
using NinjaSoftware.TrzisteNovca.Models.Admin;
using NinjaSoftware.TrzisteNovca.Common;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Controllers
{
    public class AdminController : NinjaSoftware.Api.Mvc.NsController
    {
        #region HtmlPage

        [HttpGet]
        public ActionResult HtmlPageList(int? pageNumber, string sortField, bool? isSortAscending)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                HtmlPagePager pager = new HtmlPagePager();
                pager.LoadData(adapter, pageNumber, Config.PageSize(), sortField, isSortAscending);

                return View(pager);
            }
        }

        [HttpGet]
        public ActionResult HtmlPageEdit(long? htmlPageId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
            using (adapter)
            {
                HtmlPageEntity htmlPage = GetHtmlPage(adapter, htmlPageId);
                return View(htmlPage);
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult HtmlPageEdit(long? htmlPageId, FormCollection formCollection)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                HtmlPageEntity htmlPage = GetHtmlPage(adapter, htmlPageId);

                UpdateModel(htmlPage);

                if (Helper.IsSafeHtml(formCollection["Html"]))
                {
                    if (TryUpdateAndSaveIEntity2(htmlPage, adapter, false, false))
                    {
                        return RedirectToAction("HtmlPageList");
                    }
                    else
                    {
                        return View(htmlPage);
                    }
                }
                else
                {
                    this.ViewUserErrorMessage = "Unsafe HTML";
                    return View();
                }
            }
        }

        private HtmlPageEntity GetHtmlPage(DataAccessAdapterBase adapter, long? htmlPageId)
        {
            if (htmlPageId.HasValue)
            {
                return HtmlPageEntity.FetchHtmlPage(adapter, null, htmlPageId.Value);
            }
            else
            {
                return new HtmlPageEntity();
            }
        }

        #endregion
    }
}
