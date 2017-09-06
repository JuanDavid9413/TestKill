
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCTest
{
    public class DataManager
    {
        #region Instances
        SQLServerDao vInstance = new SQLServerDao();
        #endregion
        public SqlCommand vQuery;
        public int? DeleteClient(ClientModel oClientModel)
        {
            try
            {
                using (vQuery = new SqlCommand("", vInstance.vCurrentConnetion))
                {

                }
            }
            catch
            {
                throw;
            }
            return 1;
        }
        public int? UpdateClient(ClientModel oClientModel)
        {
            return 1;
        }
        public int? InsertClient(ClientModel oClientModel)
        {
            return 1;
        }
        public List<ClientModel> GetAllClient()
        {
            List<ClientModel> vList = new List<ClientModel>();
            return vList;
        }
    }
}