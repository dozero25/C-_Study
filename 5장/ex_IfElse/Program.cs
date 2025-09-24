using System;

namespace ex_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");

            String input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0) {
                Console.WriteLine("음수입니다.");
            } 
            else if (number == 0) {
                Console.WriteLine("0입니다.");
            } 
            else {
                Console.WriteLine("양수입니다.");
            }

            if (number % 2 == 0){
                Console.WriteLine("짝수입니다.");
            }
            else {
                Console.WriteLine("홀수입니다.");
            }
        }
    }
}
