using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelsSApplications.ModelsServices;

namespace CrudClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ManagerDataClient" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ManagerDataClient.svc or ManagerDataClient.svc.cs at the Solution Explorer and start debugging.
    public class ManagerDataClient : Interfaces.ICustomClient
    {
        public void ManagerInsetClient(ClientApplicationModel clientModelServices)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.InsertClient(clientModelServices);
        }

        public void ManegerUpdateClient(ClientApplicationModel clientModelServices)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.UpdateClient(clientModelServices);
        }

        public void ManagerDeleteClient(ClientApplicationModel clientModelServices)
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            dataManager.DeleteClient(clientModelServices);
        }

        public List<ClientApplicationModel> ManagerGetDataClient()
        {
            DAO.DataManager dataManager = new DAO.DataManager();
            return dataManager.GetDataClient();
        }
    }
}
