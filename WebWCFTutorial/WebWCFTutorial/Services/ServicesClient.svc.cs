using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebWCFTutorial.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicesClient" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicesClient.svc or ServicesClient.svc.cs at the Solution Explorer and start debugging.
    public class ServicesClient : IServicesClient
    {
        public string DoWork()
        {
            return "test de wcf prueba";
        }
    }
}
