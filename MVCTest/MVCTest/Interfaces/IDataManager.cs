using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest
{
    public interface IDataManager
    {
        int? DeleteClient(ClientModel oClientModel);
        int? UpdateClient(ClientModel oClientModel);
        int? InsertClient(ClientModel oClientModel);
        List<ClientModel> GetAllClient();
    }
}
