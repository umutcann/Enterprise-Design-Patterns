using APP.Business.BusinessManager;
using APP.Log.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APP.UI.MVCUI.Controllers
{
    [Authorize]
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

        public ActionResult UsersFromDevices()
        {
            DeviceManager manager = new DeviceManager();
            var model = manager.GetUsersFromDevices();
            LogManager.WriteLog(new LogDataModel()
            {

                LogDate = DateTime.Now,
                Data = "qwer",
                User = "UCC"
            });
            return View(model);
        }
    }
}