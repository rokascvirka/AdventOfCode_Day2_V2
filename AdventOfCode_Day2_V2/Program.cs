using System.Reflection;

namespace AdventOfCode_Day2_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay2.txt");

            var games = FileReader.ReadFile(FILE_PATH);
            var sum = games.GamesInfo.Where(x => x.IsPossible).Select(x => x.GameId).Sum();
            var sumOfPowers = games.GamesInfo.Select(x => x.PowerOfSet).Sum();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Sum of powers: {sumOfPowers}");
            Console.WriteLine("Done!");

        }
    }
}