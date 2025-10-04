using System;
using System.Numerics;

namespace ex_ThisConstructor
{
    internal class Program
    {
        class MyClass {
            int a, b, c;

            public MyClass()
            {

                this.a = 5425;

                Console.WriteLine("MyClass()");
            }

            public MyClass(int b) : this()
            {
                this.b = b;
                Console.WriteLine($"MyClass({b})");
            }

            public MyClass(int b, int c) : this(b) { 
                this.c = c;
                Console.WriteLine($"MyClass({b}, {c})");
            }

            public void PrintFields() { 
                Console.WriteLine($"a: {a}, b : {b}, c : {c}");
            }
        }
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();
            
            MyClass c = new MyClass(10, 20);
            c.PrintFields();
            Console.WriteLine();

            /*
            MyClass()
            a: 5425, b : 0, c : 0

            MyClass()
            MyClass(1)
            a: 5425, b : 1, c : 0

            MyClass()
            MyClass(10)
            MyClass(10, 20)
            a: 5425, b : 10, c : 20
             */


            /*
            생성자 체이닝(constructor chaining)
            : 생성자가 다른 생성자를 호출하는 문법
            : this()의 () 안에 인수 개수와 타입을 기준으로 일치하는 생성자를 찾아 호출

             */
        }
    }
}
