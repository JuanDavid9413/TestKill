using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrudJSFinale.DAO
{
    public class DataManager : Interfaces.IDataManager
    {
        #region Atributes
        public SqlCommand query;
        #endregion

        #region Instance
        DAO.Connection connection = new Connection();
        #endregion
        public void InsertClient(Areas.Client.Models.ClientViewModel clientViewModel)
        {
            try
            {
                using (query = new SqlCommand("InsertClient", connection.vCurrentConnection))
                {
                    query.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    query.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    query.Parameters.AddWithValue("@LastName", clientViewModel.LastName);
                    query.Parameters.AddWithValue("@Age", clientViewModel.Age);
                    query.CommandType = CommandType.StoredProcedure;
                    connection.ConnectionOpen();
                    query.ExecuteNonQuery();
                    connection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateClient(Areas.Client.Models.ClientViewModel clientViewModel)
        {
            try
            {
                using (query = new SqlCommand("UpdateClient", connection.vCurrentConnection))
                {
                    query.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    query.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    query.Parameters.AddWithValue("@LastName", clientViewModel.LastName);
                    query.Parameters.AddWithValue("@Age", clientViewModel.Age);
                    query.CommandType = CommandType.StoredProcedure;
                    connection.ConnectionOpen();
                    query.ExecuteNonQuery();
                    connection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteClient(Areas.Client.Models.ClientViewModel clientViewModel)
        {
            try
            {
                using (query = new SqlCommand("DeleteClient", connection.vCurrentConnection))
                {
                    query.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    query.CommandType = CommandType.StoredProcedure;
                    connection.ConnectionOpen();
                    query.ExecuteNonQuery();
                    connection.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Areas.Client.Models.ClientViewModel> GetListClient()
        {
            try
            {
                DataRow[] dataRow;
                SqlDataAdapter adapter;
                DataTable dataTable = new DataTable();
                List<Areas.Client.Models.ClientViewModel> list = new List<Areas.Client.Models.ClientViewModel>();
                using (adapter = new SqlDataAdapter("GeDataClient", connection.vCurrentConnection))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataTable);

                    dataRow = dataTable.Select();

                    dataRow.ToList().ForEach(x =>
                    {
                        list.Add(new Areas.Client.Models.ClientViewModel
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
            catch
            {
                throw;
            }
        }
    }
}