using System;

namespace ex_Constructor
{
    class Cat {

        public string Name;
        public string Color;

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color) { 
            Name = _Name;
            Color = _Color;
        }

        ~Cat() {
            Console.WriteLine("소멸자 호출");
            Console.WriteLine($"{Name} : 잘가");
        }



        public void Meow() {
            Console.WriteLine($"{Name} : 애옹");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            /*
            ~클래스(){}
            : 종료자
            : 객체가 소멸될 때 호출되는 함수
             */

        }
    }
}
