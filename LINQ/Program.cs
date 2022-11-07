namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {"Knights of the Old Republic", "Mass Effect", "Fable", "Splinter Cell", "Risk of Rain"};

            IEnumerable<string> gameOrder =
            videoGames.OrderBy(str => str.Length)
                           .ThenBy(str => str);

            foreach(string game in gameOrder)
            Console.WriteLine(game);
        
        
        
        
            Console.ReadLine();
        }
    }
}
