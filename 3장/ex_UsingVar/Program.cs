using System;

namespace ex_UsingVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type : {0}, Value: {1}", a.GetType(), a);    // Type : System.Int32, Value: 20

            var b = 3.1414213;
            Console.WriteLine("Type : {0}, Value: {1}", b.GetType(), b);    // Type : System.Double, Value: 3.1414213

            var c = "Hello, World!";
            Console.WriteLine("Type : {0}, Value: {1}", c.GetType(), c);    // Type : System.String, Value: Hello, World!

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type : {0}, Value: ", d.GetType());

            foreach (var e in d)
                Console.Write("{0} ", e);

            // Type : System.Int32[], Value: 10 20 30

            Console.WriteLine();

            /*
             
            var
            - 정적 타입(컴파일러 시 타입 확정)
            - 타입은 초기값을 보고 컴파일러가 결정
            - 결정되면 바꿀 수 없음
            - 지역변수에서만 사용 가능, 초기화 필수

            object
            - 모든 타입의 최상위 클래스
            - 어떤 값이든 담을 수 있음
            - 실제 타입이 object 취급되므로, 다른 타입으로 사용하려면 형변환이 필요


            구분	    var	                            object
            타입결정	컴파일 시점, 초기값으로 결정	런타임 시점, object로 고정
            재할당	    같은 타입만 가능	            어떤 타입도 가능
            형변환      필요 없음	                    필요할 때 있음
            목적	    코드 간결, 타입 추론	        다양한 타입 저장, 범용성
             */
        }
    }
}
