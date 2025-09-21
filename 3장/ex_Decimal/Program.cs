using System;

namespace data_store_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);   // 3.1415927
            Console.WriteLine(b);   // 3.141592653589793
            Console.WriteLine(c);   // 3.1415926535897932384626433833

            // decimal : 29자리 데이터를 표현할 수 있는 소수 형식
            // 128비트

        }
    }
}
