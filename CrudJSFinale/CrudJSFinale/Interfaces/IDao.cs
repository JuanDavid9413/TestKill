using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudJSFinale.Interfaces
{
    public interface IDao
    {
        void ConnectionOpen();
        void ConnectionClose();
    }
}
