using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiNetFrame.Areas.Client.Models;

namespace WebApiNetFrame.Interface
{
    public interface IConnectionManager
    {
        ClientViewModel InsertClient(ClientViewModel clientViewModel);

        ClientViewModel UpdateClient(ClientViewModel clientViewModel);

        bool DeleteClient(ClientViewModel clientViewModel);

        List<ClientViewModel> GetClients();
        
    }
}
