using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.TrzisteNovca.Models;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Configuration;
using System.Web.Optimization;

namespace NinjaSoftware.TrzisteNovca
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();

            try
            {
                DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory();
                ErrorEntity.LogException(adapter, exception);
            }
            catch (Exception ex)
            {
                ErrorEntity error = new ErrorEntity(exception);
                StringWriter stringWriter = new StringWriter();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ErrorEntity));
                xmlSerializer.Serialize(stringWriter, error);
                stringWriter.Close();

                StringBuilder xmlFilePath = new StringBuilder(HttpContext.Current.Request.MapPath(HttpContext.Current.Request.ApplicationPath));

                if (xmlFilePath.Length > 0 && xmlFilePath.ToString().Substring(xmlFilePath.Length - 1, 1) != @"\")
                {
                    xmlFilePath.Append(@"\");
                }

                xmlFilePath.Append("Errors.xml");

                File.AppendAllText(xmlFilePath.ToString(), stringWriter.ToString());
            }

            try
            {
                string emailFrom = ConfigurationManager.AppSettings["ErrorMailFrom"];
                string emailTo = ConfigurationManager.AppSettings["ErrorMailTo"];
                string subject = string.Format("Application {0} error", ConfigurationManager.AppSettings["ApplicationName"]);
                string body = string.Format("<strong>Username:</strong> {0} <br /><br /><strong>Exception:</strong> <br /><br /> {1}",
                    User.Identity.Name,
                    exception.ToString());

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage("noreply@acrobyte.hr", emailTo, subject, body);
                mail.IsBodyHtml = true;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception)
            {
                // Silent fail
            }
        }
    }
}