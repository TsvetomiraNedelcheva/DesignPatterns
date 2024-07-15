namespace CommandPattern
{
    public class SellProduct : Order
    {
        Product product;
        public SellProduct(Product product)
        {
            this.product = product;
        }

        public void Execute()
        {
            product.Sell();
        }
    }

}
