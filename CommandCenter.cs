using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandCenterPart1
{
    public class CommandCenter 
    {

        public String UserName { get;  set; }
        public bool IsOperational { get;  set; }
        public int CommandsProcessed { get;  set; }

        private readonly List<string> _commandHistory = new List<string>();
        public IReadOnlyList<string> CommandHistory => _commandHistory;



        private readonly Dictionary<string, ICommand> _commands;
        public CommandCenter()
        {


            _commands = new Dictionary<string, ICommand>(StringComparer.OrdinalIgnoreCase)
        {

                ["help"]                = new HelpCommand(),
                ["status"]              = new StatusCommand(),
                ["set_name"]            = new SetNameCommand(),
                ["exit"]                = new ExitCommand(),
                ["history"]             = new HistoryCommand(),
                ["search_history"]      = new SearchHistoryCommand(),
                ["diagnostics"]         = new RunDiagnosticsCommand(),
            };


        }
        public async Task RunAsync()
        {
            Console.WriteLine("Welcome to the CommandCenter Application");
            Console.WriteLine("Enter 'help' to see the list of Command\n");

            while (IsOperational)
            {
               
                var user = Console.ReadLine();
                var key = (user ?? "").Trim();

                if (string.IsNullOrEmpty(key))
                    continue;

                if (_commands.TryGetValue(key, out var cmd))
                {
                    _commandHistory.Add(key);       
                    await cmd.ExecuteAsync(this);   
                    CommandsProcessed++;
                }
                else
                {
                    Console.WriteLine("Invalid command. Type 'help' to see available commands.\n");
                }
            }
        }
    }
}
       