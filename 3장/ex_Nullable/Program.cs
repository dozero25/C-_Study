using System;

namespace ex_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);  // False
            Console.WriteLine(a != null);   // False

            a = 3;

            Console.WriteLine(a.HasValue);  // True
            Console.WriteLine(a != null);   // True
            Console.WriteLine(a.Value);     // 3


            /*
             
            Nullable : 값 형식에 기본저긍로 null을 넣을 수 없음
                     : Nullalbe<T> 혹은 T? 문법을 사용하면 값 형식도 null 가능
            
            HasValue : 변수가 값을 가지고 있는지 확인하는 속성
                     : true 있음, false 없음

            Value : Nullable이 가진 실제 값을 가져올 때 사용
                  : 단, 값이 없으면 InvalidOperationException 발생
              */
        }
    }
}
