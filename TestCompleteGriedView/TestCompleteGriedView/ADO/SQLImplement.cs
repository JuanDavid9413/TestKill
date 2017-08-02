using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TestCompleteGriedView
{
    public class SQLImplement : IADO
    {
        #region Attributes
        public SqlConnection vCurrentConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
        #endregion

        #region Methods
        public void OpenConnection()
        {
            try
            {
                if(vCurrentConnection.State != ConnectionState.Open)
                {
                    vCurrentConnection.Open();
                }
            }
            catch
            {
                throw;
            }
        }

        public void CloseConnection()
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