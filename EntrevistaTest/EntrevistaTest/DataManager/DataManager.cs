using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace EntrevistaTest.DataManager
{
    public class DataManager : Interfaces.IDataManager;
    {
        #region Instances
        EntrevistaTest.ADO.ConnectionImplement oCurrentConnection = new ADO.ConnectionImplement();
        #endregion
        #region Propierties
        private SqlCommand vSqlCommand;
        private SqlDataAdapter vSqlDataAdapter;
        #endregion
        public int? InsertClient(Models.ClientModel oClient)
        {
            try
            {
                vSqlCommand = new SqlCommand("InsertClients", oCurrentConnection.vCurrentConnection);
                foreach (Models.ClientModel vCLient in oClient)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }                
        }

        public int? DeleteClient(Models.ClientModel oClient)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int? UpdateClient(Models.ClientModel oClient)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetClients(Models.ClientModel oClient)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}