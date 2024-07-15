namespace CommandPattern
{
    public class Product
    {
        private string name = "Notebook";
        private double price = 5.40;

        public void Buy()
        {
            Console.WriteLine("Bought {0} for {1}lv.", name, price);
        }

        public void Sell()
        {
            Console.WriteLine("Sold {0} for {1}lv.", name, price);
        }
    }

}
