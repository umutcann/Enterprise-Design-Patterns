using APP.Business.BusinessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APP.UI.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

       // [OutputCache(Duration = 10)]


        
        public string Index()
        {
            return "Hola mundo";
        }

        public ActionResult Devices()
        {
            DeviceManager manager = new DeviceManager();
            var model = manager.getMainDevices();
            return View(model);
        }
    }
}