using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDCompleted
{
    public class InfoDataModel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public DateTime Fecha { get; set; }
    }
}