using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class multiusingfunction
    {
        public static int multiply(ref int a, int b, int c)
        {
            return a * b + c;
        }
        public static void Main()
        {
            Console.WriteLine("enter a - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c - ");
            int c = Convert.ToInt32(Console.ReadLine());

            int product = multiply(ref a, b, c);
            Console.WriteLine($"product is {product}");

        }
    }
}






      