﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudJSFinale.Areas.Client.Models
{
    public class ClientViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}