using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotify("MAIL");

            notify.SendNotification(new User());

            Console.WriteLine("Hello World!");
        }
    }
}
