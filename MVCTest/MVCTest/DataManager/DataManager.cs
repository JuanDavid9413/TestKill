using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCTest
{
    public class DataManager : IDataManager
    {
        #region Instances
        SQLServerDao vInstance = new SQLServerDao();
        #endregion

        #region Propierties
        public SqlCommand vQuery;
        public SqlDataAdapter vGetData;
        public DataTable vDataTable = new DataTable();
        #endregion

        #region Methods
        public int? DeleteClient(List<ClientModel> oClientModel)
        {
            try
            {
                using (vQuery = new SqlCommand("ClientDelete", vInstance.vCurrentConnetion))
                {
                    foreach (ClientModel vDataClientModel in oClientModel)
                    {
                        vQuery.Parameters.AddWithValue("@Id", vDataClientModel.Id);
                        vQuery.Parameters.AddWithValue("@Name", vDataClientModel.Name);
                        vQuery.Parameters.AddWithValue("@LastName", vDataClientModel.LastName);
                        vQuery.Parameters.AddWithValue("@City", vDataClientModel.City);
                    }
                    vQuery.CommandType = CommandType.StoredProcedure;
                    vInstance.ConnectionOpen();
                    vQuery.ExecuteScalar();
                    vInstance.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
            return Convert.ToInt16(vQuery);
        }
        public int? UpdateClient(List<ClientModel> oClientModel)
        {
            try
            {
                using (vQuery = new SqlCommand("ClientUpdate", vInstance.vCurrentConnetion))
                {
                    foreach (ClientModel vDataClientModel in oClientModel)
                    {
                        vQuery.Parameters.AddWithValue("@Id", vDataClientModel.Id);
                        vQuery.Parameters.AddWithValue("@Name", vDataClientModel.Name);
                        vQuery.Parameters.AddWithValue("@LastName", vDataClientModel.LastName);
                        vQuery.Parameters.AddWithValue("@City", vDataClientModel.City);
                    }
                    vQuery.CommandType = CommandType.StoredProcedure;
                    vInstance.ConnectionOpen();
                    vQuery.ExecuteScalar();
                    vInstance.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
            return Convert.ToInt16(vQuery);
        }
        public int? InsertClient(List<ClientModel> oClientModel)
        {
            try
            {
                using (vQuery = new SqlCommand("ClientInsert", vInstance.vCurrentConnetion))
                {
                    foreach (ClientModel vDataClientModel in oClientModel)
                    {
                        vQuery.Parameters.AddWithValue("@Name", vDataClientModel.Name);
                        vQuery.Parameters.AddWithValue("@LastName", vDataClientModel.LastName);
                        vQuery.Parameters.AddWithValue("@City", vDataClientModel.City);
                    }
                    vQuery.CommandType = CommandType.StoredProcedure;
                    vInstance.ConnectionOpen();
                    vQuery.ExecuteScalar();
                    vInstance.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
            return Convert.ToInt16(vQuery);
        }
        public List<ClientModel> GetAllClient()
        {
            List<ClientModel> vListClient = new List<ClientModel>();
            try
            {
                using (vGetData = new SqlDataAdapter("GetClientAll", vInstance.vCurrentConnetion))
                {
                    vGetData.SelectCommand.CommandType = CommandType.StoredProcedure;
                    vInstance.ConnectionOpen();
                    vGetData.Fill(vDataTable);
                    vInstance.ConnectionClose();

                    foreach (DataRow vDataRow in vDataTable.Rows)
                    {
                        vListClient.Add(
                            new ClientModel
                            {
                                Id = Convert.ToInt16(vDataRow["Id"]),
                                Name = Convert.ToString(vDataRow["Name"]),
                                LastName = Convert.ToString(vDataRow["LastName"]),
                                City = Convert.ToString(vDataRow["City"])
                            }
                         );
                    }

                }
            }
            catch
            {
                throw;
            }

            return vListClient;
        }
        #endregion


    }
}