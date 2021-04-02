using System;

namespace Proxy
{
    class MaskOrder : IOrderableMask
    {
        public void CreateOrder(Person person)
        {
            Console.WriteLine($"Order created to {person.Address}.");
        }
    }
}
