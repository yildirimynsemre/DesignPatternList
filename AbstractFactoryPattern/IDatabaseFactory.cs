using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }
}
