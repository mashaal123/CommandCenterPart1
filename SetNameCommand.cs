using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class SetNameCommand : ICommand
    {
        public string Name => "set_name";

        public void Execute(CommandCenter center)
        {
            Console.Write("\nEnter your new name: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                center.UserName = newName.Trim();
                Console.WriteLine("User name updated!\n");
            }
        }
    }
}
