namespace Event
{
    public delegate void StockDelegate(Stock stock,
                                      decimal oldPrice);

    public class Stock
    {
        private string name;
        private decimal price;

        public event StockDelegate handler;
        //public Action
        public Stock(string name)
        {
                this.name = name;
        }
        public string Name => this.name;
        public decimal Price{ get => this.price; set => this.price = value; }

        public void ChangePriceBy(decimal percent)
        {
            decimal oldPrice = this.price;
            this.price += (this.price * percent);
            if(handler != null)
            {
                handler(this,oldPrice);
            }
        }
    }
}
