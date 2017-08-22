using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CRUDCompleted
{
    public class CRUDController : ICRUD
    {
        #region Attributes
        public SqlDataAdapter vDataAdapter;
        public SqlCommand vSqlCommand;
        #endregion

        #region Intances
        DataSet vDataSet = new DataSet();
        SQLServerDAO vSQLServerDAO = new SQLServerDAO();
        #endregion

        #region Methods
        public void InsertInfo(List<InfoDataModel> oInfoDataModel)
        {
            try
            {
                using (vSqlCommand = new SqlCommand("InsertInfo", vSQLServerDAO.vCurrentConnection))
                {
                    foreach (InfoDataModel vInfoDataModel in oInfoDataModel)
                    {
                        vSqlCommand.Parameters.AddWithValue("@oNombre", vInfoDataModel.Codigo);
                        vSqlCommand.Parameters.AddWithValue("@oApellido", vInfoDataModel.Nombre);
                        vSqlCommand.Parameters.AddWithValue("@oCiudad", vInfoDataModel.Ciudad);
                        vSqlCommand.Parameters.AddWithValue("@oFecha", vInfoDataModel.Fecha);
                    }
                    vSqlCommand.CommandType = CommandType.StoredProcedure;
                    vSQLServerDAO.ConnectionOpen();
                    vSqlCommand.ExecuteNonQuery();
                    vSQLServerDAO.ConnectionClose();

                } 
            }
            catch
            {
                throw;
            }
        }
        public void UpdateInfo(List<InfoDataModel> oInfoDataModel)
        {
            try
            {
                using (vSqlCommand = new SqlCommand("UpdateInfo", vSQLServerDAO.vCurrentConnection))
                {
                    foreach (InfoDataModel vInfoDataModel in oInfoDataModel)
                    {
                        vSqlCommand.Parameters.AddWithValue("@vCodigo", vInfoDataModel.Codigo);
                        vSqlCommand.Parameters.AddWithValue("@vNombre", vInfoDataModel.Nombre);
                    }
                    vSqlCommand.CommandType = CommandType.StoredProcedure;
                    vSQLServerDAO.ConnectionOpen();
                    vSqlCommand.ExecuteNonQuery();
                    vSQLServerDAO.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }
        public void DeleteInfo(List<InfoDataModel> oInfoDataModel)
        {
            try
            {
                using (vSqlCommand = new SqlCommand("DeleteInfo", vSQLServerDAO.vCurrentConnection))
                {
                    foreach (InfoDataModel vInfoDataModel in oInfoDataModel)
                    {
                        vSqlCommand.Parameters.AddWithValue("@oCodigo",vInfoDataModel.Codigo);
                    }
                    vSqlCommand.CommandType = CommandType.StoredProcedure;
                    vSQLServerDAO.ConnectionOpen();
                    vSqlCommand.ExecuteNonQuery();
                    vSQLServerDAO.ConnectionClose();
                }
            }
            catch
            {
                throw;
            }
        }
        public DataSet SearchData(List<InfoDataModel> oInfoDataModel)
        {
            try
            {
                using (vDataAdapter = new SqlDataAdapter("SearchInfo", vSQLServerDAO.vCurrentConnection))
                {
                    foreach (InfoDataModel vInfoDataModel in oInfoDataModel)
                    {
                        //vDataAdapter.SelectCommand.Parameters.AddWithValue("@oCodigo", vInfoDataModel.Codigo);
                        vDataAdapter.SelectCommand.Parameters.AddWithValue("@oNombre", vInfoDataModel.Nombre);
                        //vDataAdapter.SelectCommand.Parameters.AddWithValue("@oApellido", vInfoDataModel.Apellidos);
                        //vDataAdapter.SelectCommand.Parameters.AddWithValue("@oCiudad", vInfoDataModel.Ciudad);
                        //vDataAdapter.SelectCommand.Parameters.AddWithValue("@oFecha", vInfoDataModel.Fecha);
                    }
                    vDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    vSQLServerDAO.ConnectionOpen();
                    vDataAdapter.Fill(vDataSet);
                    vSQLServerDAO.ConnectionClose();
                    
                }
            }
            catch
            {
                throw;
            }
            return vDataSet;
        }
        public DataSet GetInfo()
        {
            try
            {
                using (vDataAdapter = new SqlDataAdapter("GetInfo",vSQLServerDAO.vCurrentConnection))
                {
                    vDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    vSQLServerDAO.ConnectionOpen();
                    vDataAdapter.Fill(vDataSet);
                    vSQLServerDAO.ConnectionClose();
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