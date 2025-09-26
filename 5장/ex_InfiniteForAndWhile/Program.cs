using System;

namespace ex_InfiniteForAndWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; ) { 
                Console.WriteLine(i++);
            }

            int j = 0;
            while (true) { 
                Console.WriteLine(j++);
            }

            /*
            무한대로 진행

            ctrl + c 로 종료
             */
        }
    }
}
