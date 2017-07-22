using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAML_1.Controllers
{
    public class HealthInsController : Controller
    {
        // GET: HealthIns
        public ActionResult Index()
        {
            // replace with an instance of the users account.
            AccountSettings accountSettings = new AccountSettings();

            OneLogin.Saml.Response samlResponse = new OneLogin.Saml.Response(accountSettings);
            samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]);

            if (samlResponse.IsValid())
            {                
                this.TempData["Attributes"] = samlResponse.getAllAttributes();
                Response.Write("OK!");
                Response.Write(samlResponse.GetNameID());
                System.Web.Security.FormsAuthentication.SetAuthCookie(samlResponse.GetNameID(), false);
            }
            else
            {
                Response.Write("Failed");
            }
           
            return RedirectToAction("Secure", "Home");
        }
    }
}