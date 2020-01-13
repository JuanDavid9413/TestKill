using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApiNetFrame.Interface;

namespace WebApiNetFrame.AcessData
{
    public class Connection : IConnection
    {
        public SqlConnection oCurrentConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["currentConection"].ConnectionString);

        public void ConnectionManager()
        {
            try
            {
                if (oCurrentConnection.State != ConnectionState.Open)
                {
                    oCurrentConnection.Open();
                }
                else
                {
                    oCurrentConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}