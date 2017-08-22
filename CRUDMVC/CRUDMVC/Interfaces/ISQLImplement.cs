using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMVC
{
    public interface ISQLImplement
    {
        #region CRUD

        #region Client
        int ClientInsert(List<ClientModel> vClientData);
        int ClientDelete(List<ClientModel> vClientData);
        int ClientUpdate(List<ClientModel> vClientData);
        List<ClientModel> GetClients();
        #endregion

        #endregion
    }
}
