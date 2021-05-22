using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PCBuilder.Parts;

namespace PCBuilder.Utilities
{
    public class User
    {
      
        public User()
        {

            int i = 2;
            do
            {
                Clear();
                new PCrunner($" My Personal Computer : {i}");
                i++;
                Utils.WaitForKey();
                

            } while (ReadKey().Key != ConsoleKey.Escape );
           
        }
        
        
        
    }
    
}

