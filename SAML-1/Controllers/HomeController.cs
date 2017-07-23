using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAML_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LogIn()
        {
            AccountSettings accountSettings = new AccountSettings();

            SKGSAML.Saml.AuthRequest req = new SKGSAML.Saml.AuthRequest(new AppSettings(), accountSettings);

            return Redirect(accountSettings.idp_sso_target_url + "?SAMLRequest=" + System.Net.WebUtility.UrlEncode(req.GetRequest(SKGSAML.Saml.AuthRequest.AuthRequestFormat.Base64)));


        }

        public ActionResult LogOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            return Redirect("https://preprodapfedsso.axa-tech.com/public/SiMiMsg/logout?REDIRECT=healthinsHK");
        }
        [Authorize]
        public ActionResult Secure()
        {
            ViewBag.Message = "Your contact page.";
            var myData = this.TempData["Attributes"];
            return View(myData);
        }
    }
}