using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P173
{
    class Cal
    {
        public static int p(int a, int b)
        {
            return a + b;
        }
        public static int m(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int res = Cal.p(3, 4);
            Console.WriteLine(res);

            res = Cal.m(5, 3);
            Console.WriteLine(res);
        }
    }
}
