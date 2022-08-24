using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class smallnousingfunction
    {
        public static void getsmaller(int a,int b,out int res)
        {
            if(a<b)
            {
                res = 1;
            }
            else
            {
                res = b;
            }
        }
        public static void Main()
        {
            Console.WriteLine("enter a -");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b -");
            int b =Convert.ToInt32(Console.ReadLine());

            getsmaller(a,b,out int res);
            Console.WriteLine($"{res} is smaller");
        }
    }
}
