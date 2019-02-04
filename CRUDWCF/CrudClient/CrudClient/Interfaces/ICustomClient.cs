using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ModelsSApplications.ModelsServices;

namespace CrudClient.Interfaces
{
    [ServiceContract]
    public interface ICustomClient
    {
        [OperationContract]
        void ManagerInsetClient(ClientApplicationModel clientModelServices);

        [OperationContract]
        void ManegerUpdateClient(ClientApplicationModel clientModelServices);

        [OperationContract]
        void ManagerDeleteClient(ClientApplicationModel clientModelServices);

        [OperationContract]
        List<ClientApplicationModel> ManagerGetDataClient();
    }
}
