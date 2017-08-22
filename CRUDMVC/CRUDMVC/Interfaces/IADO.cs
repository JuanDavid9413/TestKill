using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMVC
{
    public interface IADO
    {
        void connectionOpen();
        void connectionClose();
    }
}
