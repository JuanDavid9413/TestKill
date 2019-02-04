using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CrudClient.DAO
{
    public class ManagerConnection : Interfaces.IConnection
    {
        public SqlConnection vCurrentConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);

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
    }
}