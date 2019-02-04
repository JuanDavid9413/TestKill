using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFTestWeb.CustomClientServices;
using ModelsSApplications.ModelsServices;

namespace WCFTestWeb.Areas.Client.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client/Client
        public ActionResult ClientView()
        {
            return View();
        }

        public ActionResult InsertClient(ClientApplicationModel clientViewModel)
        {
            CustomClientClient customClientClient = new CustomClientClient();            
            customClientClient.ManagerInsetClient(clientViewModel);
            return View();
        }

        public ActionResult UpdateClient(ClientApplicationModel clientViewModel)
        {
            CustomClientClient customClientClient = new CustomClientClient();
            customClientClient.ManegerUpdateClient(clientViewModel);
            return View();
        }

        public ActionResult DeleteClient(ClientApplicationModel clientViewModel)
        {
            CustomClientClient customClientClient = new CustomClientClient();
            customClientClient.ManagerDeleteClient(clientViewModel);
            return View();
        }

        public JsonResult GetDataClient()
        {
            CustomClientClient customClientClient = new CustomClientClient();
            return Json(customClientClient.ManagerGetDataClient(), JsonRequestBehavior.AllowGet);
        }
    }
}