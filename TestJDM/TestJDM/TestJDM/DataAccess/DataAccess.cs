using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJDM.DataAccess
{
    public class DataAccess : Interfaces.IDataAccess
    {
        #region Instances
        Models.ConnectionEntities oInstance = new Models.ConnectionEntities();
        #endregion

        #region Methods
        public List<Models.PARAMETERS_GENERAL> GetDataGeneral()
        {
            var vList = oInstance.PARAMETERS_GENERAL.ToList();
            return vList;
        }

        public List<Models.PARAMETERS_GENERAL> GetSearchDataParametersGeneral(string vCodigo = "", string Name = "")
        {
            var vList = oInstance.PARAMETERS_GENERAL.Where(m => m.CODE_PAREMETER.Contains(vCodigo) && m.PARAMETER_NAME.Contains(Name)).ToList();
            return vList;
        }

        public int? UpdateParameter(Models.PARAMETERS_GENERAL oParameterGeneral)
        {
            return 1;
        }
        #endregion 
    }
}