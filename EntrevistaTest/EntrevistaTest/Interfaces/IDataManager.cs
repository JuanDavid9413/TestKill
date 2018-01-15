using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EntrevistaTest.Interfaces
{
    interface IDataManager
    {
        int? InsertClient(Models.ClientModel oClientModel);
        int? DeleteClient(Models.ClientModel oClientModel);
        int? UpdateClient(Models.ClientModel oClientModel);
        DataSet GetClients(Models.ClientModel oClientModel);
    }
}
