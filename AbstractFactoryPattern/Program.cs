using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomOperation customOperation = new CustomOperation(new OracleDatabaseFactory());
            CustomOperation customOperation1 = new CustomOperation(new MySQLDatabaseFactory());

            customOperation.RemoveById(1);

            Console.WriteLine("Hello World!");
        }
    }
}
