using System;
using static System.Console;

namespace ex_StringFormatBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";

            WriteLine(fmt, "Publisher", "Auther", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The ( Programming Language)");

            /*
             Publisher           Auther                                  Title
             Marvel              Stan Lee                             Iron Man
             Hanbit              Sanghyun Park                      This is C#
             Prentice Hall       K&R               The ( Programming Language)
             */

            /*
            {0,-20} : 0번째 값 출력, 20칸 확보 후 왼쪽 정렬
            {1,-15} : 1번째 값 출력, 15칸 확보 후 왼쪽 정렬
            {2, 30} : 2번째 값 출력, 30칸 확보 후 오른쪽 정렬
             */
        }
    }
}
