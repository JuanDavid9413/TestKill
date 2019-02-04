using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsSApplications.ModelsServices;

namespace CrudClient.Interfaces
{
    public interface IDataManager
    {
        void InsertClient(ClientApplicationModel clientModelServices);
        void UpdateClient(ClientApplicationModel clientModelServices);
        void DeleteClient(ClientApplicationModel clientModelServices);
        List<ClientApplicationModel> GetDataClient();
    }
}
