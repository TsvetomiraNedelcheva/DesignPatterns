namespace CommandPattern
{
    public class BuyProduct : Order
    {
        Product product;
        public BuyProduct(Product product)
        {
            this.product = product;
        }

        public void Execute()
        {
            product.Buy();
        }
    }
}
