using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();


            bool isEquals = singleton1.Id == singleton2.Id;
            Console.WriteLine($"Singleton referance is equals: {isEquals}"); //output: Database referance is equals: True

            Console.WriteLine("Hello World!");
        }
    }
}
