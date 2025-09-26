using System;

namespace ex_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--);
            } while (i > 0);

            /*
            a) i : 10
            a) i : 9
            a) i : 8
            a) i : 7
            a) i : 6
            a) i : 5
            a) i : 4
            a) i : 3
            a) i : 2
            a) i : 1
            b) i : 0

            while, do-while의 차이 : 최초 실행 여부 차이. while은 최초 조건이 false이면 실행 안됨. do-while은 최초 조건이 false여도 1회 실행됨.
             */
        }
    }
}
