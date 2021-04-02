using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class MySQLDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MySQLCommand();
        }

        public Connection CreateConnection()
        {
            return new MySQLConnection();
        }
    }
}
