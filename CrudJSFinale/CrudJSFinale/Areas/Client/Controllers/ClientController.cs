using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudJSFinale.Areas.Client.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client/Client
        public ActionResult ClientView()
        {
            return View();
        }

        public ActionResult InsertClient(Models.ClientViewModel clientViewModel)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.InsertClient(clientViewModel);
            return View();
        }

        public ActionResult UpdateClient(Models.ClientViewModel clientViewModel)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.UpdateClient(clientViewModel);
            return View();
        }

        public ActionResult DeleteClient(Models.ClientViewModel clientViewModel)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.DeleteClient(clientViewModel);
            return View();
        }

        public JsonResult GetDataClient()
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            List<Models.ClientViewModel> list = new List<Models.ClientViewModel>();
            list = dataManager.GetListClient();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}