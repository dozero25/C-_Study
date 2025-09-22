using System;
using static System.Console;

namespace ex_LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Testing && ...");
            WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");        
            WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            WriteLine("\nTesting ||  ...");
            WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            WriteLine("\nTesting !  ...");
            WriteLine($"!True : {!true}");
            WriteLine($"!False : {!false}");

            /*
            
            Testing && ...
            1 > 0 && 4 < 5 : True
            1 > 0 && 4 > 5 : False
            1 == 0 && 4 > 5 : False
            1 == 0 && 4 < 5 : False

            Testing ||  ...
            1 > 0 || 4 < 5 : True
            1 > 0 || 4 > 5 : True
            1 == 0 || 4 > 5 : False
            1 == 0 || 4 < 5 : True

            Testing !  ...
            !True : False
            !False : True
             
             */
        }
    }
}
