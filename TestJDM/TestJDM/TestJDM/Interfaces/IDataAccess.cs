using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJDM.Interfaces
{
    public interface IDataAccess
    {
        List<Models.PARAMETERS_GENERAL> GetDataGeneral();
        List<Models.PARAMETERS_GENERAL> GetSearchDataParametersGeneral(string vCodigo = "", string Name = "");
        int? UpdateParameter(Models.PARAMETERS_GENERAL oParameterGeneral);
    }
}
