﻿using System.Collections.Generic;

namespace StrategyPattern
{
    class ShoppingCart
    {
        private List<Item> _items;
        private IPayment _payment;

        public ShoppingCart()
        {
            _items = new List<Item>();
        }

        public void SetPaymentMethod(IPayment payment)
        {
            _payment = payment;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public int CalculateTotal()
        {
            int sum = 0;
            foreach (Item item in _items)
            {
                sum += item.GetPrice();
            }
            return sum;
        }

        public void Pay()
        {
            int amount = CalculateTotal();
            _payment.Pay(amount);
        }
    }
}
