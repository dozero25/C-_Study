using System;

namespace ex_PartialClass
{
    internal class Program
    {

        partial class MyClass 
        {
            public void Method1() {
                Console.WriteLine("Method1");
            }

            public void Method2()
            {
                Console.WriteLine("Method2");
            }
        }

        partial class MyClass
        {
            public void Method3()
            {
                Console.WriteLine("Method3");
            }

            public void Method4()
            {
                Console.WriteLine("Method4");
            }
        }
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();

            /*
            Method1
            Method2
            Method3
            Method4
             */

            /*
            분할 클래스
            : 하나의 클래스를 여러 파일이나 여러 코드 블록으로 나눠서 정의
            : 컴파일 시 모든 부분을 합쳐서 하나의 클래스로 만ㄷ ㅡㄹ어줌
            
            public partial class myclass(){}
             */

        }
    }
}
