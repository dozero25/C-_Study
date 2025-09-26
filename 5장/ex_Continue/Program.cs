using System;

namespace ex_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) {
                    continue;
                }
                Console.WriteLine($"{i} : 홀수");
            }

            /*
            1 : 홀수
            3 : 홀수
            5 : 홀수
            7 : 홀수
            9 : 홀수
             */
        }
    }
}
