namespace StrategyDesignPattern
{
    public class StrategyListDesc : Strategy
    {
        public List<string> Order(List<string> names)
        {
            return (List<string>)names.OrderByDescending(x => x).ToList();
        }
    }
}
