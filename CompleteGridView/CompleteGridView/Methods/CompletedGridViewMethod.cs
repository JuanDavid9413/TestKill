using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CompleteGridView
{
    public class CompletedGridViewMethod : SQLImplement
    {
        #region Instances
        SQLImplement vSQLImplement = new SQLImplement();
        #endregion

        #region Propierties
        public DataSet ds = new DataSet();
        #endregion

        #region Methods
        public DataSet GetInfo()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("GetInfo",vCurrentConnection))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);
                }
            }
            catch
            {
                throw;
            }

            return ds;
        }

        public void InsertInfo()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("InsertInfo", vCurrentConnection))
                {
                    cmd.CommandText = "InsertInfo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    ConnectionOpen();
                    cmd.ExecuteNonQuery();
                    ConnectionClose();
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