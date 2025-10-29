using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class ExitCommand : ICommand
    {
        public string Name => "exit";

        public Task ExecuteAsync (CommandCenter center)
        {
            Console.WriteLine("Goodbye, " + center.UserName);
            center.IsOperational = false;
            return Task.CompletedTask;
        }
    }
}