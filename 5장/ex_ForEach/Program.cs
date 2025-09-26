using System;

namespace ex_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (int a in arr) { 
                Console.WriteLine(a);
            }

            /*
            1
            2
            3
            4
            5

            foreach(데이터_형식 변수명 in 배열_또는_컬렉션) {
                코드_또는_코드_블록;
            }
             */
        }
    }
}
