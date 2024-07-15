using CommandPattern;

public class CommandPatternDemo
{
    public static void Main()
    {
        Product product = new Product();
        Tracker tracker = new Tracker();

        BuyProduct buyProductOrder = new BuyProduct(product);
        tracker.AddOrder(buyProductOrder);

        SellProduct sellProductOrder = new SellProduct(product);
        tracker.AddOrder(sellProductOrder);

        tracker.ShowOrders();
    }
}
