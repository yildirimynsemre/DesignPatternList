using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class Command
    {
        public abstract void ExecuteCommand(string query);
    }
}
