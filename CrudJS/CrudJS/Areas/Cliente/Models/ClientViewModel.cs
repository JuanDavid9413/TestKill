using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudJS.Areas.Cliente.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}