using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EntrevistaTest.ADO
{
    public class ConnectionImplement : Interfaces.IADO
    {
        #region Propierties
        public SqlConnection vCurrentConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
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
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}