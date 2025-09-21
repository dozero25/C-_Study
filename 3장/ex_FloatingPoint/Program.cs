using System;

namespace data_store_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);   // 3.1415927

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);   //3.1415927410125732


            // 각각 최대한으로 담을 수 있는 부분까지만 저장
            // 부동 소수점은 한계를 가짐
        }
    }
}
