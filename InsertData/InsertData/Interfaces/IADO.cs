using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertData
{
    public interface IADO
    {
        void ConnectionOpen();
        void ConnectionClose();
    }
}