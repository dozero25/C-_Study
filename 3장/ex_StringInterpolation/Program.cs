using System;
using static System.Console;

namespace ex_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "윤튼튼";
            int age = 24;
            WriteLine($"{name,-10}, {age:D3}");

            name = "한허약";
            age = 47;
            WriteLine($"{name}, {age,-10:D3}");

            name = "김평범";
            age = 15;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");


            /*
            윤튼튼       , 024
            한허약, 047
            김평범, 미성년자
             */

        }
    }
}
