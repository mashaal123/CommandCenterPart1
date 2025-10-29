using System;
using System.Linq;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class SearchHistoryCommand : ICommand
    {
        public string Name { get { return "search_history"; } }

        public Task ExecuteAsync(CommandCenter center)
        {
            Console.Write("Enter search term: ");
            string term = Console.ReadLine() ?? string.Empty;

            var results = center.CommandHistory
                .Where(c => !string.IsNullOrEmpty(c) &&
                            c.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            Console.WriteLine("\nSearch Results:");
            if (results.Count == 0)
            {
                Console.WriteLine("(no matches)");
            }
            else
            {
                foreach (var r in results)
                    Console.WriteLine(r);
            }

            Console.WriteLine();
            return Task.CompletedTask;
        }
    }
}