using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CRUDCompleted
{
    public class SQLServerDAO : IADO
    {
        #region Propierties
        public SqlConnection vCurrentConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
        #endregion

        #region Methods
        public void ConnectionOpen()
        {
            try
            {
                if (vCurrentConnection.State != ConnectionState.Open)
                {
                    vCurrentConnection.Open();
                }
            }
            catch
            {
                throw;
            }
        }
        public void ConnectionClose()
        {
            try
            {
                if (vCurrentConnection.State != ConnectionState.Closed)
                {
                    vCurrentConnection.Close();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}