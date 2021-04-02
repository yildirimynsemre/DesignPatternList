using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class OracleConnection : Connection
    {
        public override bool OpenConnection()
        {
            return true;
        }
        public override bool CloseConnection()
        {
            return true;
        }
    }
}
