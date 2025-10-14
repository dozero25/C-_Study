using System;

namespace ex_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { {1, 2, 3 }, {4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr2 = new int[,] { { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr3 = { { 10, 11, 12, 13 }, { 14, 15, 16, 17 } };

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr3[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
            [0, 0] : 1 [0, 1] : 2 [0, 2] : 3
            [1, 0] : 4 [1, 1] : 5 [1, 2] : 6

            [0, 0] : 4 [0, 1] : 5 [0, 2] : 6
            [1, 0] : 7 [1, 1] : 8 [1, 2] : 9

            [0, 0] : 10 [0, 1] : 11 [0, 2] : 12 [0, 3] : 13
            [1, 0] : 14 [1, 1] : 15 [1, 2] : 16 [1, 3] : 17
             */
        }
    }
}
