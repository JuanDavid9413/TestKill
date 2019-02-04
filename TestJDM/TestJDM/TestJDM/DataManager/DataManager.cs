using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJDM.DataManager
{
    public class DataManager : Interfaces.IDataManager
    {
        #region instances
        DataAccess.DataAccess oInstanceDataAccess = new DataAccess.DataAccess();
        #endregion

        #region Methods
        public  List<Models.PARAMETERS_GENERAL> ManagerDataListParameterGeneral()
        {
            return oInstanceDataAccess.GetDataGeneral();
        }

        public List<Models.PARAMETERS_GENERAL> ManagerSearchDataParametersGeneral(string vCodigo ="", string vName = "")
        {
            return oInstanceDataAccess.GetSearchDataParametersGeneral(vCodigo,vName);
        }

        public int? ManagerUpdateParameterData(Models.PARAMETERS_GENERAL oParameterGeneralModel)
        {
            return oInstanceDataAccess.UpdateParameter(oParameterGeneralModel);
        }
        #endregion

    }
}