using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenterPart1
{
    public class Program
    {
       public static async Task Main(string[] args)
        {
  
            
            var center = new CommandCenter(); 
           await center.RunAsync();
           
                }
            }
        }

       
                