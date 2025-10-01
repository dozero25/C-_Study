using System;

namespace ex_UsingParams
{
    internal class Program
    {
        static int Sum(params int[] args) {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                if ( i > 0 ) { 
                    Console.Write(", ");
                }
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum = {sum}");

            /*
            Summing... 3, 4, 5, 6, 7, 8, 9, 10
            Sum = 52
             */

            /*
            params
            : 사용 시 동일한 타입의 인자를 0개 이상 전달
            : 메서드 내에서 배열로 처리
            : 한 메서드에 params 키워드는 1개만 허용
             */
        }
    }
}
