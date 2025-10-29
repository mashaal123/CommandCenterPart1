using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class RunDiagnosticsCommand : ICommand
    {

        public string Name => "diagnostics";

        public async Task ExecuteAsync(CommandCenter center)
        {
            Console.WriteLine("Running system diagnostics...");
            await Task.Delay(5000);
            Console.WriteLine("Diagnostics complete. All systems are nominal.\n");
        }
    }
}

