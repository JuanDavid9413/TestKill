using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ModelsSApplications.ModelsServices;

namespace CrudClient.DAO
{
    public class DataManager : Interfaces.IDataManager
    {
        #region instances
        DAO.ManagerConnection ManagerConnection = new ManagerConnection();
        #endregion

        #region Attributtes
        SqlCommand comand;
        SqlDataAdapter dapter;
        #endregion

        public void InsertClient(ClientApplicationModel clientModelServices)
        {
            try
            {
                using (comand = new SqlCommand("InsertClient", ManagerConnection.vCurrentConnection))
                {
                    comand.Parameters.AddWithValue("@Id",clientModelServices.Id);
                    comand.Parameters.AddWithValue("@Name", clientModelServices.Name);
                    comand.Parameters.AddWithValue("@LastName", clientModelServices.LastName);
                    comand.Parameters.AddWithValue("@Age", clientModelServices.Age);
                    comand.CommandType = CommandType.StoredProcedure;
                    ManagerConnection.ConnectionOpen();
                    comand.ExecuteNonQuery();
                    ManagerConnection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateClient(ClientApplicationModel clientModelServices)
        {
            try
            {
                using (comand = new SqlCommand("UpdateClient", ManagerConnection.vCurrentConnection))
                {
                    comand.Parameters.AddWithValue("@Id", clientModelServices.Id);
                    comand.Parameters.AddWithValue("@Name", clientModelServices.Name);
                    comand.Parameters.AddWithValue("@LastName", clientModelServices.LastName);
                    comand.Parameters.AddWithValue("@Age", clientModelServices.Age);
                    comand.CommandType = CommandType.StoredProcedure;
                    ManagerConnection.ConnectionOpen();
                    comand.ExecuteNonQuery();
                    ManagerConnection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteClient(ClientApplicationModel clientModelServices)
        {
            try
            {
                using (comand = new SqlCommand("DeleteClient", ManagerConnection.vCurrentConnection))
                {
                    comand.Parameters.AddWithValue("@Id", clientModelServices.Id);
                    comand.CommandType = CommandType.StoredProcedure;
                    ManagerConnection.ConnectionOpen();
                    comand.ExecuteNonQuery();
                    ManagerConnection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<ClientApplicationModel> GetDataClient()
        {
            List<ClientApplicationModel> list = new List<ClientApplicationModel>();
            DataTable dataTable = new DataTable();
            
            using (dapter = new SqlDataAdapter("GeDataClient", ManagerConnection.vCurrentConnection))
            {
                dapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                ManagerConnection.ConnectionOpen();
                dapter.Fill(dataTable);
                ManagerConnection.ConnectionClose();

                var vGetDataTable = dataTable.Select();

                vGetDataTable.ToList().ForEach(x => {
                    list.Add(new ClientApplicationModel
                    {
                        Id = (int)x["Id"],
                        Name = (string)x["Name"],
                        LastName = (string)x["LastName"],
                        Age = (int)x["Age"]
                    });
                });
            }
                return list;
        }
    }
}