using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionBD_ADO
{
    public class SQLServerImplement : IADO
    {
        #region Properties
        SqlConnection vConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConention"].ConnectionString);
        #endregion

        #region Connection BD
        public void ConnectionOpen()
        {
            try
            {
                if (vConnection.State != ConnectionState.Open)
                {
                    vConnection.Open();
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
                if (vConnection.State != ConnectionState.Closed)
                {
                    vConnection.Close();
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