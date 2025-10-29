using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";

        public Task ExecuteAsync (CommandCenter center)
        {
            Console.WriteLine("\nAvailable Commands:");
            Console.WriteLine("help             - Show list of commands");
            Console.WriteLine("set_name         - Change the user name");
            Console.WriteLine("status           - Show current status");
            Console.WriteLine("history          - Show recent command");
            Console.WriteLine("search_history   - search commands history");
            Console.WriteLine("diagnostics      - Run simulated system diagnostics");
            Console.WriteLine("exit             - Exit the program\n");
            return Task.CompletedTask;
        }
    }
}