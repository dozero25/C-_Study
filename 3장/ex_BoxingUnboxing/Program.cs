using System;

namespace ex_BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int) b;

            Console.WriteLine(a);   // 123
            Console.WriteLine(b);   // 123
            Console.WriteLine(c);   // 123

            double x = 3.1414213;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);   // 3.1414213
            Console.WriteLine(y);   // 3.1414213
            Console.WriteLine(z);   // 3.1414213


            /*
             boxing : 값 형식을 참조형식으로 변환, int or string 타입을 -> object, System.ValueType으로 변환
                    : 스택 -> 힙
             unboxing : 참조 형식의 값을 꺼내오는 형태
                      : 힙 -> 스택
             
             문제 : 성능 문제 -> 비용이 큼
                  : 잘못된 캐스팅 예외 -> Unboxing 시 타입이 다르면 InvalidCastException 발생
             */
        }
    }
}
