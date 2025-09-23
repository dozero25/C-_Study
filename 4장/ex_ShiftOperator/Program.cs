using System;
using static System.Console;

namespace ex_ShiftOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Testing <<....");

            int a = 1;
            WriteLine("a      : {0:D5} (0x{0:X8})", a);
            WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
            WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2);
            WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5);

            WriteLine("\nTesting >>....");

            int b = 255;
            WriteLine("b      : {0:D5} (0x{0:X8})", b);
            WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1);
            WriteLine("b >> 2 : {0:D5} (0x{0:X8})", b >> 2);
            WriteLine("b >> 5 : {0:D5} (0x{0:X8})", b >> 5);

            WriteLine("\nTesting >> 2....");

            int c = -255;
            WriteLine("c      : {0:D5} (0x{0:X8})", c);
            WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);
            WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);
            WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);


            /*
            Testing <<....
            a      : 00001 (0x00000001)
            a << 1 : 00002 (0x00000002)
            a << 2 : 00004 (0x00000004)
            a << 5 : 00032 (0x00000020)

            Testing >>....
            b      : 00255 (0x000000FF)
            b >> 1 : 00127 (0x0000007F)
            b >> 2 : 00063 (0x0000003F)
            b >> 5 : 00007 (0x00000007)

            Testing >> 2....
            c      : -00255 (0xFFFFFF01)
            c >> 1 : -00128 (0xFFFFFF80)
            c >> 2 : -00064 (0xFFFFFFC0)
            c >> 5 : -00008 (0xFFFFFFF8)
             */
        }
    }
}
