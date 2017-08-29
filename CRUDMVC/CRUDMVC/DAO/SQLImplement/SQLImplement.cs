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
        DataTable vDataTable = new DataTable();
        #endregion

        #region Propierties
        public int vResultQuery;
        public SqlDataAdapter vSqlDataAdapter;
        #endregion

        #region CRUD

        #region Client
        public int? ClientInsert(List<ClientModel> oClientData)
        {
            using (SqlCommand vSqlCommand = new SqlCommand("ClientInsert", vSqlImplement.vCurrentConnection))
            {
                foreach (ClientModel vClientModel in oClientData)
                {
                    vSqlCommand.Parameters.AddWithValue("@Name", vClientModel.Name);
                    vSqlCommand.Parameters.AddWithValue("@LastName", vClientModel.Lastname);
                    vSqlCommand.Parameters.AddWithValue("@City", vClientModel.City);

                }
                vSqlCommand.CommandType = CommandType.StoredProcedure;
                vSqlImplement.connectionOpen();
                vResultQuery = Convert.ToInt16(vSqlCommand.ExecuteScalar());
                vSqlImplement.connectionClose();
            }
            return vResultQuery;
        }
        public int? ClientDelete(List<ClientModel> oClientData)
        {
            using (SqlCommand vClientDelete = new SqlCommand("ClientDelete", vSqlImplement.vCurrentConnection))
            {
                foreach (ClientModel vClientModel in oClientData)
                {
                    vClientDelete.Parameters.AddWithValue("@Id",vClientModel.Id);
                }
                vClientDelete.CommandType = CommandType.StoredProcedure;
                vSqlImplement.connectionOpen();
                vResultQuery = Convert.ToInt16(vClientDelete.ExecuteScalar());
                vSqlImplement.connectionClose();
            }
                return vResultQuery;
        }
        public int? ClientUpdate(List<ClientModel> oClientData)
        {
            using (SqlCommand vClientUpdate = new SqlCommand("ClientUpdate", vSqlImplement.vCurrentConnection))
            {
                foreach(ClientModel vClientData in oClientData )
                {
                    vClientUpdate.Parameters.AddWithValue("@Id", vClientData.Id);
                    vClientUpdate.Parameters.AddWithValue("@Name", vClientData.Name);
                    vClientUpdate.Parameters.AddWithValue("@LastName", vClientData.Lastname);
                    vClientUpdate.Parameters.AddWithValue("@City", vClientData.City);
                }
                vClientUpdate.CommandType = CommandType.StoredProcedure;
                vSqlImplement.connectionOpen();
                vResultQuery = Convert.ToInt16(vClientUpdate.ExecuteScalar());
                vSqlImplement.connectionClose();
            }
                return vResultQuery;
        }
        public List<ClientModel> GetClients()
        {
            using (vSqlDataAdapter = new SqlDataAdapter("GetClientAll", vSqlImplement.vCurrentConnection))
            {
                vSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                vSqlImplement.connectionOpen();
                vSqlDataAdapter.Fill(vDataTable);
                vSqlImplement.connectionClose();
            }

            List<ClientModel> vlistClientModel = new List<ClientModel>();


            foreach (DataRow vDataRow in vDataTable.Rows)
                vlistClientModel.Add(
                        new ClientModel
                        {
                            Id = Convert.ToInt16(vDataRow["Id"]),
                            Name = Convert.ToString(vDataRow["Name"]),
                            Lastname = Convert.ToString(vDataRow["LastName"]),
                            City = Convert.ToString(vDataRow["City"])
                        }
                    );
                
                
            return vlistClientModel;
        }
        #endregion
        
        #endregion

    }
}