﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudJS.Interfaces
{
    public interface IConnection
    {
        void ConnectionOpen();
        void ConnectionClose();
    }
}
