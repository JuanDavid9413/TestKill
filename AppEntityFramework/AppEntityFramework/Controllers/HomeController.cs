using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        Models.currentConnection oInstanceConnection = new Models.currentConnection();
        // GET: Home
        public ActionResult Index()
        {
            var vTable_Users = oInstanceConnection.Cliente.ToList();
            return View(vTable_Users);
        }

        public ActionResult CreateClient()
        {
            return View();
        }

        public ActionResult CreateClient(Models.Cliente oClient)
        {
            oInstanceConnection.Cliente.Add(oClient);
            oInstanceConnection.SaveChanges();
            return View();
        }
    }
}