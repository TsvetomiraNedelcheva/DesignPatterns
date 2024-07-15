namespace StrategyDesignPattern
{
    public class StrategyListAsc : Strategy
    {
        public List<string> Order(List<string> names)
        {
            return (List<string>)names.OrderBy(x => x).ToList();
        }
    }
}
