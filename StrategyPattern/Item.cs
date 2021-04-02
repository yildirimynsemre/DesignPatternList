namespace StrategyPattern
{
    class Item
    {
        private string _upcCode;
        private int _price;

        public Item(string upcCode, int price)
        {
            _upcCode = upcCode;
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
