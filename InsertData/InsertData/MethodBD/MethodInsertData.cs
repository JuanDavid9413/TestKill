using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace InsertData
{
    public class MethodInsertData
    {
        #region Attributes
        public SqlCommand vSqlCommand;
        public SqlDataAdapter vSqlDataAdapter;
        #endregion

        #region Instances
        public DataSet vDataSet = new DataSet();
        SQLImplement vSqlImplement = new SQLImplement();
        #endregion

        #region Methods
        public void InsertData(int id, List<InfoDataModel> vDataModel)
        {
            try
            {
                using (vSqlCommand = new SqlCommand("InsertInfo", vSqlImplement.vCurrentConnection))
                {
                    vSqlCommand.CommandType = CommandType.StoredProcedure;
                    vSqlCommand.Parameters.Add("@Id",vDataModel);

                }
            }
            catch
            {
                throw;
            }
        }

        public DataSet GetInfo()
        {
            try
            {
                using (vSqlDataAdapter = new SqlDataAdapter("GetInfo", vSqlImplement.vCurrentConnection))
                {
                    vSqlCommand.CommandType = CommandType.StoredProcedure;
                    vSqlImplement.ConnectionOpen();
                    vSqlDataAdapter.Fill(vDataSet);
                    vSqlImplement.ConnectionClose();
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