using System;

namespace Observer
{
    class ObserverUser : IObserverUser
    {
        public void SendNotification(ProductUpdateMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
