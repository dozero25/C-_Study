using System;
using System.Diagnostics.Metrics;

namespace ex_SwapByValue
{
    internal class Program
    {
        public static void Swap(int a, int b) {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");    // Before Swap: x = 3, y = 4

            Swap(x, y); 
            Console.WriteLine($"After Swap: x = {x}, y = {y}");     // After Swap: x = 3, y = 4
        }
    }
}
