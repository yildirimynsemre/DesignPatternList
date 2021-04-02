namespace Observer
{
    class Samsung : ObservableProduct
    {
        // Ürün fiyatı değiştikten sonra Observer örneklerine bildirim gönderilir.
        public void ChangePrice()
        {
            // Ürün fiyatlarının güncellenmesi vs.

            this.message.productName = "Samsung";
            this.message.message = "Samsung's price updated.";
            this.NotifyObserver();
        }
    }
}
