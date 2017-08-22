using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CRUDMVC
{
    public class SQLConnectionBD : IADO
    {
        #region Propierties
        public SqlConnection vCurrentConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
        #endregion

        #region Methods
        public void connectionOpen()
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

        public void connectionClose()
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