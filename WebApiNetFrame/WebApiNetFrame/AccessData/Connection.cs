using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using WebApiNetFrame.Interfaces;

namespace WebApiNetFrame.AccessData
{
    public class Connection : IConnection
    {
        public void ConnectionManager()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}