namespace Observer
{
    interface IObserverUser
    {
        void SendNotification(ProductUpdateMessage message);
    }
}
