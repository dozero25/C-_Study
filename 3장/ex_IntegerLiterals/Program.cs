using System;

namespace data_store_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 240;   // 10빈수 리터럴
            Console.WriteLine($"a = {a}");

            byte b = 0b111_000; // 2진수 리터럴
            Console.WriteLine($"b = {b}");

            byte c = 0XF0;   // 16진수 리터럴
            Console.WriteLine($"c = {c}");

            uint d = 0x1234_abcd;   // 16진수 리터럴
            Console.WriteLine($"d = {d}");
        }
    }
}
