using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiNetFrame.AcessData;
using WebApiNetFrame.Areas.Client.Models;

namespace WebApiNetFrame.Areas.Client.Controllers
{
    public class ClientController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            try
            {
                ConnectionManager connectionManager = new ConnectionManager();
                var result = connectionManager.GetClients();
                return Json(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public IHttpActionResult InsertClient([FromUri]ClientViewModel clientViewModel)
        {
            try
            {
                ConnectionManager connectionManager = new ConnectionManager();
                var result = connectionManager.InsertClient(clientViewModel);
                return Json(result);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPut]
        public void UpdateClient()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete]
        public void DeleteClient()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
    }
}
