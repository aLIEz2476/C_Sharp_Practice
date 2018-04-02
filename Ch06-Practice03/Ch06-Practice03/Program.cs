using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_Practice03
{
    class Program
    {
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
        static void Main(string[] args)
        {
            int a = 3, b = 4;
            int resA = 0;

            Plus(a, b, out resA);
            Console.WriteLine("{0} + {1} = {2}", a, b, resA);

            double x = 2.4, y = 3.1;
            double resB = 0;

            Plus(x, y, out resB);
            Console.WriteLine("{0} + {1} = {2}", x, y, resB);
        }
    }
}
