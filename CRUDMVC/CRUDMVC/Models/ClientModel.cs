using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUDMVC
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite el Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite el Apellido")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Digite la ciudad")]
        public string City { get; set; }
    }
}