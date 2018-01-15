using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntrevistaTest.Models
{
    public class ClientModel
    {

        #region Propiedades
        [Required(ErrorMessage ="This Name is Required") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "This LastName is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Sexo is Required")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "This City is Required")]
        public string City { get; set; }

        #endregion
    }
}