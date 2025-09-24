using System;

namespace ex_SwitchExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요.");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine();
            bool repeated = line == "y"?true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}" );

            /*
            문자열을 숫자나 다른 타입으로 바꿀 때 사용하는 경우 : Parse, TryParse, Convert

            Convert.ToInt32() : null을 0으로 변환, 빈 문자열을 0으로 변환

             */
        }
    }
}
