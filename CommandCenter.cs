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


        private readonly Dictionary<string, ICommand> _commands;
        public CommandCenter()
        {

            UserName = "Guest";
            IsOperational = true;
            CommandsProcessed = 0;


            _commands = new Dictionary<string, ICommand>
            {
                {"help",new HelpCommand() },
                {"status",new StatusCommand() },
                {"set_name",new SetNameCommand() },
                {"exit",new ExitCommand() },
            };

        }
        public void Run()
        {

            Console.WriteLine("Welcome to the CommandCenter Applicatione");
            Console.WriteLine(" Enter 'help' to see the list of Command");


            while (IsOperational)
            {

                string user = Console.ReadLine().ToLower(); // 


                if (_commands.ContainsKey(user))
                {
                    _commands[user].Execute(this);
                    CommandsProcessed++;
                }

                else
                {
                    Console.WriteLine("Invalid command. write 'help' to see available commands.");

                }
            }
        }
    }
}
       