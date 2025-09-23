﻿using System;

namespace ex_NullCoalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");           // 0

            num = 99;
            Console.WriteLine($"{num ?? 0}");           // 9

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");   // Default

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");   // Specific
        }
    }
}
