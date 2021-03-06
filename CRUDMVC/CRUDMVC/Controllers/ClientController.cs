﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMVC
{
    public class ClientController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
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
                throw;
            }
        }

        public ActionResult EditClient()
        {
            return View();
        }

        [HttpPost]
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
                    ViewBag.Message = "Se edito correctamente";
                }
            }
            catch
            {
                throw;
            }
            return View();
        }

        public ActionResult DeleteClient()
        {
            return View();
        }

        [HttpPost]
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
