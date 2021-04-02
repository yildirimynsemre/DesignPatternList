using System;

namespace StrategyPattern
{
    class PaypalPayment : IPayment
    {
        private string _email;
        private string _password;

        public PaypalPayment(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Pay(int amount)
        {
            // Kredi kartı ödeme işlemlerinin gerçekleştiği yer.
            Console.WriteLine("Paid by Paypal.");
        }
    }
}
