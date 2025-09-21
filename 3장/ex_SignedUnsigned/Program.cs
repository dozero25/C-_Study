using System;

namespace data_store_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);   // 255
            Console.WriteLine(b);   // -1
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0')); // 1111 1111

            /*
            byte의 범위는 0 ~ 255
            sbyte의 범위는 -128 ~ 127
            
            255의 2 진수는 1111 1111
            sbyte로 해석하면 최상위 비트가 음수로 변경

            2의 보수 규칙에 따라 1111 1111 = -1

            2의 보수 규칙 : 수는 이진수를 모두 반전하고 1을 더해 표현하며, 덧셈과 뺄셈을 같은 회로로 처리할 수 있게 해줌
             */

        }
    }
}
