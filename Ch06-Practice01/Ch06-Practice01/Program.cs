using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_Practice01
{
    class Program
    {
        static double Square(double arg)
        {
            return arg *= arg;
        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);
            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
