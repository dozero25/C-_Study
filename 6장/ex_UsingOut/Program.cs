using System;

namespace ex_UsingOut
{
    internal class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder) {
            quotient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c
            // int d

            Divide(a, b, out int c, out int d);
            Console.WriteLine($"a : {a}, b : {b} a/b : {c}, a%b {d}");  // a : 20, b : 3 a/b : 6, a%b 2

            /*
            out, ref
            : 모두 참조 전달하는 방식
            : 변수의 값을 복사해서 전달하지 않고, 변수가 저장된 메모리 위치 주소를 전달

            ref
            : 메서드가 기존 변수의 값을 읽거나 수정해야 할 때 사용
            : 메서드가 호출되기 전에 변수가 반드시 초기화 되어 있어야 함

            out
            : 메서드가 새 값을 계산해서 돌려줄 때 사용
            : 초기화할 필요 없음
            : 메서드 안에 반드시 값을 할당해야 함
             */
        }
    }
}
