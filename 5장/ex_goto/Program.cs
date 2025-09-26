using System;

namespace ex_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("종료 조건(숫자)를 입력하세요. : ");
            int input_num = Convert.ToInt32(Console.ReadLine());

            int exit_num = 0;

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    for (int k = 0; k < 3; k++) {
                        if (exit_num++ == input_num) { 
                             goto EXIT_FOR;
                        }
                        Console.WriteLine(exit_num);
                    }
                }
            }
            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");
        EXIT_PROGRAM:
            Console.WriteLine("Exit program....");
        }

        /*
        종료 조건(숫자)를 입력하세요. : 20
        1
        2
        3
        4
        5
        6
        7
        8
        9
        10
        11
        12
        Exit program....
         */


        /*
        goto 
        : 특정 위치(레이블)로 프로그램 흐름을 즉시 이동시키는 명령문
        : 코드의 가독성을 떨어뜨리고 유지보수를 어렵게 만들 수 있으므로, 일반적으로 권장되지 않음
         */

    }
}
