using System;

namespace ex_CTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;
            var ab = 123456;

            Console.WriteLine("a Type : {0}, Value : {1}", a.GetType().ToString(), a);  // a Type : System.Int32, Value : 123
            Console.WriteLine("b Type : {0}, Value : {1}", b.GetType().ToString(), b);  // b Type : System.Int32, Value : 456
            Console.WriteLine(a.GetType().ToString() == b.GetType().ToString());        // True
            Console.WriteLine(a.GetType().ToString() == ab.GetType().ToString());       // True


            Console.WriteLine();

            System.String c = "abc";
            string d = "def";
            var cd = "abcdef";

            Console.WriteLine("c Type : {0}, Value : {1}", c.GetType().ToString(), c);  // c Type : System.String, Value : abc
            Console.WriteLine("d Type : {0}, Value : {1}", d.GetType().ToString(), d);  // d Type : System.String, Value : def
            Console.WriteLine(c.GetType().ToString() == d.GetType().ToString());        // True
            Console.WriteLine(c.GetType().ToString() == cd.GetType().ToString());       // True


            /*
            공용형식 시스템
            : .NET에서 모든 데이터 타입이 어떻게 생겼는지, 어떻게 동작하는지, 어떻게 서로 호환되는지를 정의한 시스템
            : 즉, 모든 .NET 언어가 공통으로 이해할 수 있는 타입 규칙을 제공하는 것

            목적
            1. 언어 간 호환성
            - C#에서 만든 클래스 → VB.NET, F#에서도 그대로 사용 가능

            2. 타입 안전성 보장
            - 잘못된 타입 사용을 컴파일 시점이나 런타임에 방지

            3. 효율적인 실행
            - CLR이 타입 정보를 표준화해서 코드 실행과 메모리 관리를 쉽게 함
             

            구성요소
            1. 값 타입(Value Type)
            - 스택에 저장
            - 변수 자체가 데이터를 가짐
            - ex) : int, float, bool, struct

            2. 참조 타입(Reference Type)
            - 힙에 저장
            - 변수는 실제 데이터의 주소를 가짐
            - ex) : string, class, interface, delegate


            Boxing, Unboxing
            : CTS에서 값 타입과 참조 타입을 호환하려면 Boxing/Unboxing이 필요
            : Boxing 값 타입 -> 참조 타입
            : Unboxing 참조 타입 -> 값 타입




             */
        }
    }
}
