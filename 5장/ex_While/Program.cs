using System;

namespace ex_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0) {
                Console.WriteLine($"i : {i--}");
            }

            /*
            i : 10
            i : 9
            i : 8
            i : 7
            i : 6
            i : 5
            i : 4
            i : 3
            i : 2
            i : 1
             */
        }
    }
}
