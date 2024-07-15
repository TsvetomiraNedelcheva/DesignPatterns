namespace StrategyDesignPatternPhotoStudio
{
    public class ClassicEdit : Strategy
    {
        public void PrintPhotoEditInfo()
        {
            Console.WriteLine("Classic edit will cost 10lv.");
        }
    }
}
