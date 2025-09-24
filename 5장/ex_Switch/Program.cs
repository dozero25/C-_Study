using System;

namespace ex_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요. (월, 화, 수, 목, 금, 토, 일) : ");
            String day = Console.ReadLine();

            switch (day) 
            {
                case "월":
                    Console.WriteLine("Monday");
                    break;

                case "화":
                    Console.WriteLine("Tuesday");
                    break;

                case "수":
                    Console.WriteLine("Wednesday");
                    break;

                case "목":
                    Console.WriteLine("Thursday");
                    break;

                case "금":
                    Console.WriteLine("Friday");
                    break;

                case "토":
                    Console.WriteLine("Saturday");
                    break;

                case "일":
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}
