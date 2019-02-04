using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TestJDM.Controllers
{
    public class ParameterController : Controller
    {
        #region Instances
        DataManager.DataManager oDataManager = new DataManager.DataManager();
        #endregion
        //
        // GET: /Parameter/
        [HttpGet]
        public ActionResult Index()
        {
            return View(oDataManager.ManagerDataListParameterGeneral());
        }

        [HttpPost]
        public ActionResult Index(string Codigo, string Name)
        {
            return View(oDataManager.ManagerSearchDataParametersGeneral(Codigo, Name));
        }

        public ActionResult UpdateParameter(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {

            }
            return RedirectToAction("Index", "Parameter");
        }

        
	}
}