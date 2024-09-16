namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st = new Stock("Meta");
            st.handler += St_handler;

            st.Price = 100;

            st.ChangePriceBy(0.5m);
            st.ChangePriceBy(-0.25m);
            st.ChangePriceBy(0);

        }

        private static void St_handler(Stock stock, decimal oldPrice)
        {
            string State="";
            if(stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                State = "HARDLUCK";
            }
            else if(stock.Price > oldPrice) {
                Console.ForegroundColor = ConsoleColor.Green;
                State = "WINNER WINNER CHICKEN DINNER";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                State = "NO CHANGE";
            }
            Console.WriteLine($"--{stock.Name}-- Price: ${stock.Price} {State}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------");

        }
    }

    
}
