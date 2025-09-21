using System;

namespace ex_IntegralConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);   // 127

            int b = (int)a;
            Console.WriteLine(b);   // 127

            int x = 128;
            Console.WriteLine(x);   // 128

            sbyte y = (sbyte)x;
            Console.WriteLine(y);   // -128

        }
    }
}
