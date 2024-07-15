namespace CommandPattern
{
    public class Tracker
    {
        private List<Order> orderList = new List<Order>();

        public void AddOrder(Order order)
        {
            orderList.Add(order);
        }

        public void ShowOrders()
        {
            foreach (Order order in orderList)
            {
                order.Execute();
            }
        }
    }
}
