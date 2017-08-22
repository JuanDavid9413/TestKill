using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CRUDMVC
{
    public class SQLImplement : ISQLImplement
    {
        #region Instances
        SQLConnectionBD vSqlImplement = new SQLConnectionBD();
        #endregion

        #region CRUD
        #region Client
        public int ClientInsert(List<ClientModel> vClientData)
        {
            using (SqlCommand vSqlCommand = new SqlCommand("ClienteInsert", vSqlImplement.vCurrentConnection))
            {
                foreach (ClientModel vClientModel in vClientData)
                {
                    vSqlCommand.Parameters.AddWithValue("@Name", vClientModel.Name);
                    vSqlCommand.Parameters.AddWithValue("@LastName", vClientModel.Lastname);
                    vSqlCommand.Parameters.AddWithValue("@City", vClientModel.City);

                }
                vSqlCommand.CommandType = CommandType.StoredProcedure;
                vSqlImplement.connectionOpen();
                vSqlCommand.ExecuteReader();
            }
                return 1;
        }
        public int ClientDelete(List<ClientModel> vClientData)
        {
            return 1;
        }
        public int ClientUpdate(List<ClientModel> vClientData)
        {
            return 1;
        }
        public List<ClientModel> GetClients()
        {
            List<ClientModel> list = new List<ClientModel>();
            return list;
        }
        #endregion
        #endregion

    }
}