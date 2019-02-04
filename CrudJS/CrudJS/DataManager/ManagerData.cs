using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrudJS.DataManager
{
    public class ManagerData : Interfaces.IDataManager
    {
        Connection.ConnectionManager ConnectionManager = new Connection.ConnectionManager();
        SqlDataAdapter SqlData;
        SqlCommand command;
        DataTable dataTable = new DataTable();

        public void InsertClient(Areas.Cliente.Models.ClientViewModel clientViewModel)
        {
            try
            {
                using (command = new SqlCommand("InsertClient", ConnectionManager.vCurrentConnection))
                {
                    command.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    command.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    command.Parameters.AddWithValue("@LastName", clientViewModel.LastName);
                    command.Parameters.AddWithValue("@Age", clientViewModel.Age);
                    command.CommandType = CommandType.StoredProcedure;
                    ConnectionManager.ConnectionOpen();
                    command.ExecuteNonQuery();
                    ConnectionManager.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateClient(Areas.Cliente.Models.ClientViewModel clientViewModel)
        {
            try
            {
                using (command = new SqlCommand("UpdateClient", ConnectionManager.vCurrentConnection))
                {
                    command.Parameters.AddWithValue("@Id", clientViewModel.Id);
                    command.Parameters.AddWithValue("@Name", clientViewModel.Name);
                    command.Parameters.AddWithValue("@LastName", clientViewModel.LastName);
                    command.Parameters.AddWithValue("@Age", clientViewModel.Age);
                    command.CommandType = CommandType.StoredProcedure;
                    ConnectionManager.ConnectionOpen();
                    command.ExecuteNonQuery();
                    ConnectionManager.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteClient(int Id)
        {
            try
            {
                using (command = new SqlCommand("DeleteClient", ConnectionManager.vCurrentConnection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ConnectionManager.ConnectionOpen();
                    command.ExecuteNonQuery();
                    ConnectionManager.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Areas.Cliente.Models.ClientViewModel> GetDataClient()
        {
            DataRow[] dataRow;
            List<Areas.Cliente.Models.ClientViewModel> list = new List<Areas.Cliente.Models.ClientViewModel>();
            using (SqlData = new SqlDataAdapter("GeDataClient", ConnectionManager.vCurrentConnection))
            {
                SqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                ConnectionManager.ConnectionOpen();
                SqlData.Fill(dataTable);
                ConnectionManager.ConnectionClose();

                dataRow = dataTable.Select();

                dataRow.ToList().
                    ForEach(x =>
                    {
                        list.Add(new Areas.Cliente.Models.ClientViewModel
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