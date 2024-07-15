namespace StrategyDesignPattern
{
    public class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void executeStrategy(List<string> names)
        {
            var namesSorted = strategy.Order(names).ToList();
           
            foreach (var name in namesSorted)
            {
                Console.Write(name + " ");
            }
        }
    }
}
