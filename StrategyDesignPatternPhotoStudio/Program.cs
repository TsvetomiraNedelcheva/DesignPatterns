using StrategyDesignPatternPhotoStudio;
public class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context(new ModernEdit());
        context.ExecuteStrategy();

        context = new Context(new RetroEdit());
        context.ExecuteStrategy();

        context = new Context(new ClassicEdit());
        context.ExecuteStrategy();
    }
}

