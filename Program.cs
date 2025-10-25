using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part1
            String UserName = "Guest";
            bool isOperational = true;
            int commandsProcessed=0;

            Console.WriteLine("Welcome to the CommandCenter Applicatione");
            Console.WriteLine(" Enter 'help' to see the list of Command");

            
            while (isOperational)
            {
               
                string user = Console.ReadLine().ToLower(); // 
                commandsProcessed++;

                if (user == "help")
                {
                    ShowHelp();
                }
                else if (user == "set_name")
                {
                    UserName = SetUserName();
                }
                else if (user == "status")
                {
                    ShowStatus(UserName, isOperational, commandsProcessed);
                }
                else if (user == "exit")
                {
                    Console.WriteLine("Goodbye, " + UserName );
                    isOperational = false;
                }
                else
                {
                    Console.WriteLine("Invalid command. write 'help' to see available commands.");

                }
            }
        }

        // Methods
        static void ShowHelp()
        {
            Console.WriteLine("\nAvailable Commands:");
            Console.WriteLine("help      - Show list of commands");
            Console.WriteLine("set_name  - Change the user name");
            Console.WriteLine("status    - Show current status");
            Console.WriteLine("exit      - Exit the program\n");
        }

        static string SetUserName()
        {
            Console.WriteLine("\nNew Name:");
            Console.WriteLine("Enter your new name: ");
            string NewName = Console.ReadLine();
            return NewName;
           
        }

        static void ShowStatus(string UserName, bool isOperational, int commandsProcessed)
        {
            Console.WriteLine("\nStatus:");
            Console.WriteLine("User Name: " + UserName);
            Console.WriteLine("Operational: " + isOperational);
            Console.WriteLine("Commands Processed: " + commandsProcessed);
            Console.WriteLine("\n");
        }
    }
}
                