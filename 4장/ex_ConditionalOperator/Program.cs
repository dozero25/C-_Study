using System;

namespace ex_ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);    // 짝수
        }
    }
}
