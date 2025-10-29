using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class HistoryCommand : ICommand
    {
        public string Name => "history";

        public Task ExecuteAsync(CommandCenter center)
        {
            if (center.CommandHistory.Count == 0)
            {
                Console.WriteLine("\nNo history yet.\n");
                return Task.CompletedTask;
            }

            Console.WriteLine("\nCommand History:");
            for (int i = 0; i < center.CommandHistory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {center.CommandHistory[i]}");
            }
            Console.WriteLine();
            return Task.CompletedTask;
        }
    }
}
