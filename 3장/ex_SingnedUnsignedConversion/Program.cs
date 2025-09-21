using System;

namespace ex_SingnedUnsignedConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);   // 500

            uint b = (uint)a;
            Console.WriteLine(b);   // 500

            int x = -30;
            Console.WriteLine(x);   // -30

            uint y = (uint)x;
            Console.WriteLine(y);   // 4294967266
        }
    }
}
