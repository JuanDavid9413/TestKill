using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WCFTest1
{
    public class Service1 : ICliente
    {
        #region Variable Globales
        private SqlConnection vCurrentConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["currentConnection"].ConnectionString);
        private SqlDataAdapter vQuery;
        private DataTable dttTest = new DataTable();
        #endregion

        #region Methods
        #endregion
        public ClientModel GetClienteById(int Id)
        {
            ClientModel iClientModel = new ClientModel();
            using (vQuery = new SqlDataAdapter("GetClient", vCurrentConnection))
            {
                vQuery.SelectCommand.Parameters.AddWithValue("@PI_Id", Id);
            }
            vQuery.SelectCommand.CommandType = CommandType.StoredProcedure;
            vCurrentConnection.Open();
            vQuery.Fill(dttTest);
            vCurrentConnection.Close();

            foreach (DataRow vDataRow in dttTest.Rows)
            {
                iClientModel.Id = Convert.ToInt16(vDataRow["Id"]);
                iClientModel.Name = vDataRow["Name"].ToString();
                iClientModel.LastName = vDataRow["LastName"].ToString();
                iClientModel.Sexo = vDataRow["Sexo"].ToString();
                iClientModel.City = vDataRow["City"].ToString();
            }
            return iClientModel;
        }
    }
}
