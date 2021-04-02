namespace Observer
{
    class ProductUpdateMessage
    {
        public string productName;
        public string message;

        public override string ToString()
        {
            return $"{productName} updated. Message: {message}";
        }
    }
}
