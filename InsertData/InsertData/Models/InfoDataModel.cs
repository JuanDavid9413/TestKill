using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertData
{
    public class InfoDataModel
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Ciudad { set; get; }
        public DateTime Fecha { set; get; }

    }
}