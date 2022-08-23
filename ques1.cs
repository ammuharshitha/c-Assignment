using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ques1
    {
        public static void Main()
        {
            int a;
            int b;
            int c;
            int d;
            a =int.Parse( Console.ReadLine());
            b =int.Parse( Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            d = a * b * c;
                Console.WriteLine(d);
        }
    }
}