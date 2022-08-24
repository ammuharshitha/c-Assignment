using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class array
    {
        public static void Main()
        {

            string[] values = { "ammu", "nancy", "harshitha", "chaitra" };
            Console.WriteLine(values.Count());
            foreach (string name in values)
                Console.WriteLine(name.ToUpper());
            
             
        }
    }
}
