using System.Collections.Generic;

namespace Observer
{
    abstract class ObservableProduct
    {
        private List<IObserverUser> _users;
        protected ProductUpdateMessage message;

        public ObservableProduct()
        {
            _users = new List<IObserverUser>();
            message = new ProductUpdateMessage();
        }

        public void AddObserver(IObserverUser observerUser)
        {
            _users.Add(observerUser);
        }

        public void RemoveObserver(IObserverUser observerUser)
        {
            _users.Remove(observerUser);
        }

        public void NotifyObserver()
        {
            foreach (IObserverUser user in _users)
            {
                user.SendNotification(message);
            }
        }
    }
}
