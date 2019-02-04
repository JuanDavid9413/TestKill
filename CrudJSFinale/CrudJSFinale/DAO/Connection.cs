using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CrudJSFinale.DAO
{
    public class Connection : Interfaces.IDao
    {
        #region Attributes
        public SqlConnection vCurrentConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["currenteConnection"].ConnectionString);
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