using System;

namespace ex_RelationalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 > 4 : {3 > 4}");      // 3 > 4 : False
            Console.WriteLine($"3 >= 4 : {3 >= 4}");    // 3 >= 4 : False
            Console.WriteLine($"3 < 4 : {3 < 4}");      // 3 < 4 : True
            Console.WriteLine($"3 <= 4 : {3 <= 4}");    // 3 <= 4 : True
            Console.WriteLine($"3 == 4 : {3 == 4}");    // 3 == 4 : False
            Console.WriteLine($"3 != 4 : {3 != 4}");    // 3 != 4 : True

        }
    }
}
