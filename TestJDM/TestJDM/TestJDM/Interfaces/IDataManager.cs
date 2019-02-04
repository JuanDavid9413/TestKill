using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJDM.Interfaces
{
    public interface IDataManager
    {
        List<Models.PARAMETERS_GENERAL> ManagerDataListParameterGeneral();
        List<Models.PARAMETERS_GENERAL> ManagerSearchDataParametersGeneral(string vCodigo = "", string Name = "");
        int? ManagerUpdateParameterData(Models.PARAMETERS_GENERAL oParameterGeneralModel);
    }
}
