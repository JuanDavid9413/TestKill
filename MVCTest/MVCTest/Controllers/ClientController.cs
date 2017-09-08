using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeleteClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteClient(ClientModel oClienModel)
        {
            return View();
        }

        public ActionResult InsertClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertClient(ClientModel oClienModel)
        {
            return View();
        }

        public ActionResult UpdateClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateClient(ClientModel oClientModel)
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetDetailsClient()
        {
            return View();
        }

    }
}