using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudJS.Interfaces
{
    public interface IDataManager
    {
        void InsertClient(Areas.Cliente.Models.ClientViewModel clientViewModel);
        void UpdateClient(Areas.Cliente.Models.ClientViewModel clientViewModel);
        void DeleteClient(int Id);
        List<Areas.Cliente.Models.ClientViewModel> GetDataClient();
    }
}
