using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class age
    {
        static void Main(string[] args)
        {
            int age_after_10_years, your_age;
            Console.Write("Enter your current age");
            your_age = int.Parse(Console.ReadLine());
            age_after_10_years = your_age + 10;
            Console.WriteLine("value of age after 10 years:" + age_after_10_years);
            Console.WriteLine();
            
        }
    }
}
