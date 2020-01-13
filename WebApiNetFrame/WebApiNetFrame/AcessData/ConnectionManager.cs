using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApiNetFrame.Interface;
using WebApiNetFrame.Areas.Client.Models;

namespace WebApiNetFrame.AcessData
{
    public class ConnectionManager : IConnectionManager
    {
        private static Connection Connection = new Connection();
        private static SqlCommand SqlCommand = null;

        public ClientViewModel InsertClient(ClientViewModel clientViewModel)
        {
            try
            {
                using (SqlCommand = new SqlCommand("InsertClient", Connection.oCurrentConnection))
                {
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    SqlCommand.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@LastName", clientViewModel.LastName);
                    SqlCommand.Parameters.AddWithValue("@Age", clientViewModel.Age);
                    Connection.ConnectionManager();
                    var result = (ClientViewModel)SqlCommand.ExecuteScalar();
                    Connection.ConnectionManager();
                    return result;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ClientViewModel UpdateClient(ClientViewModel clientViewModel)
        {
            try
            {
                using (SqlCommand = new SqlCommand("UpdateClient", Connection.oCurrentConnection))
                {
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@LastName", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@Age", clientViewModel.Name);
                    Connection.ConnectionManager();
                    var result = (ClientViewModel)SqlCommand.ExecuteScalar();
                    Connection.ConnectionManager();
                    return result;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DeleteClient(ClientViewModel clientViewModel)
        {
            try
            {
                using (SqlCommand = new SqlCommand("DeleteClient", Connection.oCurrentConnection))
                {
                    SqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommand.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@LastName", clientViewModel.Name);
                    SqlCommand.Parameters.AddWithValue("@Age", clientViewModel.Name);
                    Connection.ConnectionManager();
                    var result = (bool)SqlCommand.ExecuteScalar();
                    Connection.ConnectionManager();
                    return result;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ClientViewModel> GetClients()
        {
            try
            {
                DataTable dataTable = new DataTable();
                DataRow[] dataRow = null;
                SqlDataAdapter sqlDataAdapter = null;
                List<ClientViewModel> clientViewModels = new List<ClientViewModel>();
                using (sqlDataAdapter = new SqlDataAdapter("GeDataClient", Connection.oCurrentConnection))
                {
                    sqlDataAdapter.Fill(dataTable);
                    dataRow = dataTable.Select();
                    dataRow.ToList().ForEach(x => 
                    {
                        clientViewModels.Add(new ClientViewModel()
                        {
                            Name = (string)x["Name"],
                            LastName = (string)x["LastName"],
                            Age = (int)x["Age"]
                        });
                    });
                    return clientViewModels;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}