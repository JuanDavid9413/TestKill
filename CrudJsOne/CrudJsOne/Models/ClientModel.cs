using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudJsOne.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Models.GenderModel GenderModel { get; set; }
    }
}