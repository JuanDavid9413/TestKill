using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestEntityCRUD.Controllers
{
    public class UsersController : Controller
    {
        #region Instances
        Models.EntityFrameworkTestEntities oInstances = new Models.EntityFrameworkTestEntities();
        #endregion
        // GET: Users
        public ActionResult Index()
        {
            var getList = oInstances.USERS.ToList();
            return View(getList);
        }

        public ActionResult InsertClient(Models.USERS oUsers)
        {
            oInstances.USERS.Add(oUsers);
            oInstances.SaveChanges();
            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public ActionResult UpdateClient(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                var vRegister = oInstances.USERS.Where(x => x.ID_USER == id);
                return View(vRegister);
            }
        }

        [HttpPost]
        public ActionResult UpdateClient(Models.USERS oUsersU)
        {
            var UpdateModel = oInstances.USERS.Where(x => x.ID_USER == oUsersU.ID_USER);
            foreach(var Client in UpdateModel)
            {
                Client.NAME = Client.NAME.Replace(Client.NAME, oUsersU.NAME);
                Client.LastName = Client.LastName.Replace(Client.LastName, oUsersU.LastName);
                Client.City = Client.City.Replace(Client.City, oUsersU.City);
                Client.LAST_MODIFIED = System.DateTime.Now;
            }

            oInstances.SaveChanges();
            return RedirectToAction("Index", "Users");
        }
    }
}