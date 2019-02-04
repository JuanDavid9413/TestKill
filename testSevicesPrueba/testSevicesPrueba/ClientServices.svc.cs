using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace testSevicesPrueba
{
    public class ClientServices : ClientModel
    {
        public string GetData(int value)
        {
            return "prueba";
        }
    }
}
