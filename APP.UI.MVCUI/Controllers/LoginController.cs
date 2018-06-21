using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace APP.UI.MVCUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult DoLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoLogin(FormCollection collection)
        {
            string user = collection.Get("userName");
            string pass = collection.Get("password");
            if (user == "1" && pass == "1")
            {
                FormsAuthentication.SetAuthCookie(user, false);
                return RedirectToAction("Index","Home");
            }
            return View();
        }


    }
}