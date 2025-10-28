using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class StatusCommand : ICommand
    {
        public string Name => "status";

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("\nStatus:");
            Console.WriteLine("User Name: " + center.UserName);
            Console.WriteLine("Operational: " + center.IsOperational);
            Console.WriteLine("Commands Processed: " + center.CommandsProcessed + "\n");
        }
    }
}