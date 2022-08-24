using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pgm1
{
    internal class INOUT
    {
        public static  void ApluseB(ref int a, int b)
        {
            a+=b;
        }
        public static void Divide(int a,int b,out int res,out int rem)
        {
            rem = a % b;
            res = a/b;
        }
            public  static void Main()
            {
                int a = 10;
                int b = 10;
                ApluseB( ref a, b);
            int res, rem;
            Divide(a, b, out res, out rem);
            Console.WriteLine($"a={a},b={b},result={res},remainder={rem}");
            }
        }
    }

