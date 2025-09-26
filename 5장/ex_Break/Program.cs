using System;

namespace ex_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니요) : ");
                string input = Console.ReadLine();

                if (input == "아니요")
                    break;

                /*
                 * 
                계속할까요?(예/아니요) : 예
                계속할까요?(예/아니요) : 예
                계속할까요?(예/아니요) : 예
                계속할까요?(예/아니요) : 예
                계속할까요?(예/아니요) : 예
                계속할까요?(예/아니요) : 아니요
                 
                 */

            }
        }
    }
}
