using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace TestCompleteGriedView
{
    public class AccessMethodsCRUD : IMethods
    {
        #region Intances
        SQLImplement vSQLImplement = new SQLImplement();
        #endregion

        #region Attributes
        SqlCommand vSqlCommand;
        SqlDataAdapter vSqlDataAdapter;
        DataSet vDataSet = new DataSet();

        #endregion

        #region Methods
        public DataSet GetInfo()
        {
            try
            {
                using (vSqlDataAdapter = new SqlDataAdapter("GetInfo", vSQLImplement.vCurrentConnection))
                {
                    vSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    vSQLImplement.OpenConnection();
                    vSqlDataAdapter.Fill(vDataSet);
                    vSQLImplement.CloseConnection();
                }
            }
            catch
            {
                throw;
            }
            return vDataSet;
        }
        #endregion
    }
}