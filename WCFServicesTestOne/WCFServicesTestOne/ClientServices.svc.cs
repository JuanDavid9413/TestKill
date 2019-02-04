using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServicesTestOne.Models;

namespace WCFServicesTestOne
{
    public class ClientServices : IClient
    {
        public string SetData(ClientModel oClientModel)
        {

            return string.Format("El nombre es {0}, El apellido {1}, La edad es: {2}, La fecha : {3}",
                oClientModel.Name, oClientModel.LastName, oClientModel.Age, oClientModel.BirdayDate);
        }
    }
}
