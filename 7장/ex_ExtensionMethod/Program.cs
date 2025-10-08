using System;
using MyExtension;

namespace MyExtension {
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++) 
                result = result * myInt;

            return result;
        }
    }
}

namespace ex_ExtensionMethod
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");   // 3 ^ 2 : 9
            Console.WriteLine($"3^4 : {3.Power(4)}");   // 3 ^ 4 : 81
            Console.WriteLine($"2^10 : {2.Power(10)}"); // 2 ^ 10 : 1024

            /*
            확장 메서드
            : 기존에 있는 타입(클래스, 구조체 등)에 새로운 메서드를 추가하는 것처럼 보이지만, 실제로는 정적 메서드를 호출하는 방식
            : 원본 타입의 소스 코드를 수정하지 않고도 기능을 붙일 수 있음
            
            선언 방법
            : 정적클래스(static class) 안에 정의
            : 정적 메서드(static method)로 정의
            : 첫 번째 매개변수 앞에 this 키워드 사용 -> this 뒤에 오는 타입이 확장하려는 대상 타입
             */
        }
    }
}
