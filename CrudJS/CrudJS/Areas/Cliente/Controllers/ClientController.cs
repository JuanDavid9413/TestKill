using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudJS.Areas.Cliente.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public ActionResult ClientView()
        {
            return View();
        }

        public ActionResult ClientViewInsert(Areas.Cliente.Models.ClientViewModel clientViewModel)
        {
            DataManager.ManagerData managerData = new DataManager.ManagerData();
            managerData.InsertClient(clientViewModel);
            return View();
        }

        public ActionResult ClientViewUpdate(Areas.Cliente.Models.ClientViewModel clientViewModel)
        {
            DataManager.ManagerData managerData = new DataManager.ManagerData();
            managerData.UpdateClient(clientViewModel);
            return View();
        }

        public ActionResult ClientViewDelete(int Id)
        {
            DataManager.ManagerData managerData = new DataManager.ManagerData();
            managerData.DeleteClient(Id);
            return View();
        }

        [HttpGet]
        public JsonResult GetDataClient()
        {
            DataManager.ManagerData managerData = new DataManager.ManagerData();
            List<Areas.Cliente.Models.ClientViewModel> list = new List<Models.ClientViewModel>();
            list = managerData.GetDataClient();
            return Json(list,JsonRequestBehavior.AllowGet);
        }

    }
}