using SATypeAnalyzer;

namespace StaticMethodAnalayzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Dev\Github\StaticAbstraction\Utility\StaticMethodAnalyzer\Output";

            var analyzer = new TypeAnalyzer(path);

            analyzer.Go();
        }
    }
}
