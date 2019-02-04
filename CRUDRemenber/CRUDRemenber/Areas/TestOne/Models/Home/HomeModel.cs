using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDRemenber.Areas.TestOne.Models.Home
{
    public class HomeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Models.GenderModel GenderModel { get; set; }

    }
}