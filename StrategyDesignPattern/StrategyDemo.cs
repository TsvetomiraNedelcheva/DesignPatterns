//Създайте програма, която да сортира списък от имена по възходящ и низходящ ред.
//Използвайте Strategy шаблон.

using StrategyDesignPattern;

public class StrategyDemo
{
    public static void Main()
    {
        List<string> names = new List<string>() { "Anna", "Jake", "Sam", "Max", "Emma" };

        Context context = new Context(new StrategyListAsc());
        context.executeStrategy(names);

        Console.WriteLine();

        context = new Context(new StrategyListDesc());
        context.executeStrategy(names);
    }
}
