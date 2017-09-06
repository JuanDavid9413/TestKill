using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCTest
{
    public class SQLServerDao: IADO
    {
        #region Propierties
        public SqlConnection vCurrentConnetion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
        #endregion

        #region Methods
        public void ConnectionOpen()
        {
            try
            {
                if (vCurrentConnetion.State != ConnectionState.Open)
                {
                    vCurrentConnetion.Open();
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
                if (vCurrentConnetion.State != ConnectionState.Closed)
                {
                    vCurrentConnetion.Close();
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