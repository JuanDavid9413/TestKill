using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectionBD_ADO
{
    public interface IADO
    {
        void ConnectionOpen();

        void ConnectionClose();
        
    }
}