using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class CommandCenter
    {

        public String UserName { get; private set; }
        public bool IsOperational { get; private set; }
        public int CommandsProcessed { get; private set; }

        public CommandCenter()
        {

            UserName = "Guest";
            IsOperational = true;
            CommandsProcessed = 0;

        }
        public void Run()
        {

            Console.WriteLine("Welcome to the CommandCenter Applicatione");
            Console.WriteLine(" Enter 'help' to see the list of Command");

            
            while (IsOperational)
            {
               
                string user = Console.ReadLine().ToLower(); // 
                

                if (user == "help")
                {
                    ShowHelp();
                    CommandsProcessed++;
                }
                else if (user == "set_name")
                {
                   UserName =SetUserName();
                    CommandsProcessed++;
                }
                else if (user == "status")
                {
                    ShowStatus();
                    CommandsProcessed++;
                }
                else if (user == "exit")
                {
                  Console.WriteLine("Goodbye, " + UserName);
                   IsOperational = false;
                }
                else
                 {
                 Console.WriteLine("Invalid command. write 'help' to see available commands.");

                 }
            }
        }


        public void ShowHelp()
        {
            Console.WriteLine("\nAvailable Commands:");
            Console.WriteLine("help      - Show list of commands");
            Console.WriteLine("set_name  - Change the user name");
            Console.WriteLine("status    - Show current status");
            Console.WriteLine("exit      - Exit the program\n");
        }

        public string  SetUserName()
        {
            Console.WriteLine("\nNew Name:");
            Console.WriteLine("Enter your new name: ");
            string New = Console.ReadLine();
            return New;

        }

        public void ShowStatus()
        {
            Console.WriteLine("\nStatus:");
            Console.WriteLine("User Name: " + UserName);
            Console.WriteLine("Operational: " + IsOperational);
            Console.WriteLine("Commands Processed: " + CommandsProcessed);
            Console.WriteLine("\n");
        }
    }
}