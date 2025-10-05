using System;

namespace ex_TypeCasting
{
    class Mammal {
        public void Nurse() {
            Console.WriteLine("Nurse()");
        }     
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();  // 업캐스팅
            Dog dog;

            if (mammal is Dog) {
                dog = (Dog)mammal;      // 다운캐스팅
                dog.Bark(); // Bark()
            }

            Mammal mammal2 = new Cat(); // 업캐스팅

            Cat cat = mammal2 as Cat;   // as 키워드

            if (cat != null) { 
                cat.Meow(); // Meow()
            }

            Cat cat2 = mammal as Cat;   // 다운 캐스팅 실패 -> null 반환
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else {
                Console.WriteLine("cat2 is not a Cat"); // cat2 is not a Cat
            }


            /*
            as 키워드
            : nullable 값 타입 변환할 때 사용하는 안전한 캐스팅 연산자
            : 다운 캐스팅 할 때 주로 사용하며, 실패 시 예외를 던지지 않고 null을 반환
             */

        }
    }
}
