using System;

namespace ex_IncDecOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); // 10 <- 현재 값 출력 후 ++
            // a는 현재 11
            Console.WriteLine(++a); // 12 <- 바로 적용

            Console.WriteLine(a--); // 12
            Console.WriteLine(--a); // 10
        }
    }
}
