using System;

namespace ex_FloatConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);    // 69.6875

            double b = (double)a;
            Console.WriteLine("b : {0}", b);    // 69.6875
            Console.WriteLine("69.6875 == b : {0}", b == 69.6875);    // 69.6875 == b : True

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);    //  0.1

            double y = (double)x;
            Console.WriteLine("y : {0}", y);    // 0.10000000149011612
            Console.WriteLine("0.1 == y : {0}", y == 0.1);    // 0.1 == y : False


            /*
             
            float -> double 변환 시 차이 정리

            1. 69.6875f가 유지되는 이유
            - 69.6875f는 2진수로 정확히 표현 가능한 값 -> 69.6875(10) = 1000101.1011(2)
            - float(23비트) 안에 정확히 저장할 수 있으므로 손실이 없음
            - double(52비트)로 변환해도 값이 변하지 않음

            2. 0.1f가 깨지는 이유
            - 0.1은 2진수로 무한 반복되는 소수 -> 0.1(10) ≈ 0.0001100110011001100110011...(2)
            - 잘린 값을 double로 변환하면, 오차가 더 정밀하게 드러남
             */

        }
    }
}
