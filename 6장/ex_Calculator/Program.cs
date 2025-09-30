using System;

namespace ex_Calculator
{

    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4); // 7
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);    // 3
            Console.WriteLine(result);
        }
    }
}
