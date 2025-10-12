using System;

namespace ex_ArraySample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;    // 배열의 마지막 - 1
            scores[^1] = 34;    // 배열의 마지막

            int sum = 0;

            foreach (int i in scores)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / scores.Length);

            /*
            80
            74
            81
            90
            34

            359
            71
             */
        }
    }
}
