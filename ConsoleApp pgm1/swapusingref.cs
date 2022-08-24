using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class swapusingref
    {
        public static void swap(ref int a,ref int b)
        {
            int t = a;
            a = b;b = t;
        }
        public static void Main()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"before swapping a={a},b={b}");
            swap(ref a,ref b);
            Console.WriteLine($"after swapping a={a},b={b}");
        }
    }
}
