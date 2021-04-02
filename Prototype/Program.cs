using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee gulizar = new Employee("Gülizar", "Yılmaz");
            Employee cloneGulizar = gulizar.Clone();

            Console.WriteLine(gulizar == cloneGulizar);
        }
    }
}
