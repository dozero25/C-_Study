using System;

namespace ex_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);   // 123
            Console.WriteLine(b);   // 3.1415926535897932384626433833
            Console.WriteLine(c);   // True
            Console.WriteLine(d);   // 안녕하세요

            // object : 모든 데이터 형식이 자동으로 object 형식으로 상속
            // 모든 데이터의 조상
        }
    }
}
