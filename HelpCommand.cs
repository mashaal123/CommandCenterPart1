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

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("\nAvailable Commands:");
            Console.WriteLine("help      - Show list of commands");
            Console.WriteLine("set_name  - Change the user name");
            Console.WriteLine("status    - Show current status");
            Console.WriteLine("exit      - Exit the program\n");
        }
    }
}