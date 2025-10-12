using System;

namespace ex_ArraySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            int sum = 0;
            Console.Write($"점수 : ");
            foreach (int score in scores)
            { 
                sum += score;
                Console.Write($"{score} ");
            }
            Console.WriteLine();

            Console.WriteLine($"총 점수 : {sum}");
            int average = sum / scores.Length;

            Console.WriteLine($"평균 : {average}");

            /*
            점수 : 80 74 81 90 34
            총 점수 : 359
            평균 : 71
             */
        }
    }
}
