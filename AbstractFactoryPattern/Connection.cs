using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class Connection
    {
        public abstract bool OpenConnection();
        public abstract bool CloseConnection();
    }
}
