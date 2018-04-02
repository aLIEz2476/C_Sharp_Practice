using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P184
{
    class Program
    {
        static void Div(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 3, c = 0, d = 0;
            Div(a, b, out c, out d);
            Console.WriteLine("a:{0}, b:{1}, q:{2}, r:{3}", a, b, c, d);
            // 참조값 출력 키워드인 out을 이용하여 void상태의 함수에서도 안정적인 출력을 할 수 있다.
            
        }
    }
}
