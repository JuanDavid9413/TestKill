using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMVC
{
    public class ClientController : Controller
    {
        // GET: Client
        [HttpGet]
        public ActionResult GetClientAll()
        {
            SQLImplement oClient = new SQLImplement();
            //ModelState.Clear();
            return View(oClient.GetClients());
        }

        // GET: Client/Create
        public ActionResult CreateClient()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult CreateClient(ClientModel oClientModel)
        {
            try
            {
                List<ClientModel> listClientModel = new List<ClientModel>();
                listClientModel.Add(oClientModel);

                if (ModelState.IsValid)
                {
                    SQLImplement oClient = new SQLImplement();
                    if (oClient.ClientInsert(listClientModel) != null)
                    {
                        ViewBag.Message = "Se inserto correctamente el cliente";
                    }
                    else
                    {
                        ViewBag.Message = "No se realizo la insercion ";
                    }
                }

                return RedirectToAction("CreateClient");
            }
            catch
            {
                return View(oClientModel);
            }
        }

        // GET: Client/Edit/5
        public ActionResult EditClient(ClientModel oClientData)
        {
            List<ClientModel> listClientModel = new List<ClientModel>();
            listClientModel.Add(oClientData);

            try
            {
                //Instance Object SqlImplemt
                SQLImplement oClient = new SQLImplement();

                if (oClient.ClientUpdate(listClientModel) != null)
                {
                    ViewBag.Message = "";
                }
            }
            catch
            {
                throw;
            }
            return View();
        }
       
        public ActionResult DeleteClient(ClientModel oClientData)
        {
            try
            {
                SQLImplement vDeleteClient = new SQLImplement();
                List<ClientModel> vListClientModel = new List<ClientModel>();
                vListClientModel.Add(oClientData);
                vDeleteClient.ClientDelete(vListClientModel);

                ViewBag.Message("Delete Correctamente");
            }
            catch
            {
                ViewBag.Message("One Error");
            }
            return View();
        }
    }
}
