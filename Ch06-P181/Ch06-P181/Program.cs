using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P181
{
    
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = b;
            b = a;
            a = t;
        }
        // return 같은 과정이 없어도 참조 키워드인 ref로 해결할 수 있다.

        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Swap(ref x, ref y);
            Console.WriteLine("x:{0}, y:{1}", x, y);
        }
    }
}
