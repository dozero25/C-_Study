using System;

namespace ex_Return
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if( n < 2) 
                return n;
            else 
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone) {
            if (name == "") {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 파보니치 수 : {Fibonacci(10)}");    // 10번째 파보니치 수 : 55

            PrintProfile("", "123-4567");          // 이름을 입력해주세요.
            PrintProfile("홍길동", "456-1230");    // Name: 홍길동, Phone: 456-1230
        }
    }
}
