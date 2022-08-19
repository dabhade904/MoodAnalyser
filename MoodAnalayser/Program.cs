namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            var mood=MoodAnalyzer.AnalyseMood("i am sad");
            Console.WriteLine(mood);
        }
    }
}
