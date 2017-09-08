using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest
{
    public interface IDataManager
    {
        int? DeleteClient(List<ClientModel> oClientModel);
        int? UpdateClient(List<ClientModel> oClientModel);
        int? InsertClient(List<ClientModel> oClientModel);
        List<ClientModel> GetAllClient();
    }
}
