using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudJSFinale.Interfaces
{
    public interface IDataManager
    {
        void InsertClient(Areas.Client.Models.ClientViewModel clientViewModel);
        void UpdateClient(Areas.Client.Models.ClientViewModel clientViewModel);
        void DeleteClient(Areas.Client.Models.ClientViewModel clientViewModel);
        List<Areas.Client.Models.ClientViewModel> GetListClient();
    }
}
