namespace Proxy
{

    class AuthenticatableMaskOrderProxy : IOrderableMask
    {
        private IOrderableMask _orderMask;

        public AuthenticatableMaskOrderProxy()
        {
            _orderMask = new MaskOrder();
        }

        public void CreateOrder(Person person)
        {
            bool isValid = CheckPersonIsValid(person);

            if (isValid)
            {
                _orderMask.CreateOrder(person);
            }
        }

        private bool CheckPersonIsValid(Person person)
        {
            return person.TC.Length == 11 && person.Address != "";
        }
    }
}
