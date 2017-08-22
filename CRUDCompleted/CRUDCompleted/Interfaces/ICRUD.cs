using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CRUDCompleted
{
    interface ICRUD
    {
        void InsertInfo(List<InfoDataModel> vDataModel);
        void UpdateInfo(List<InfoDataModel> vDataModel);
        void DeleteInfo(List<InfoDataModel> vDataModel);
        DataSet SearchData(List<InfoDataModel> vDataModel);
        DataSet GetInfo();

    }
}
