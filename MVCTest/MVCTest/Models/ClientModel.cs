using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCTest
{
    public class ClientModel
    {
        [Required (ErrorMessage ="Digite un Id")]
        public int Id { get; set; }
        [Required (ErrorMessage ="Digite un nombre")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Digite un apellido")]
        public string LastName { get; set; }
        [Required (ErrorMessage ="Digite una ciudad")]
        public string City { get; set; }
    }
}