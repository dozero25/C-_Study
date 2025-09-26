using System;

namespace ex_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"i : {i}");
            }

            /*
            i : 0
            i : 1
            i : 2
            i : 3
            i : 4
             */
        }
    }
}
