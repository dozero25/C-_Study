using System;

namespace ex_Overriding
{
    internal class Program
    {
        class ArmorSuite {
            public virtual void Initialize() {
                Console.WriteLine("Armored");
            }
        }

        class IronMan : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            /*
            Creating ArmorSuite...
            Armored
            */

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();
            /*
            Creating IronMan...
            Armored
            Repulsor Rays Armed
            */
            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
            /*
            Creating WarMachine...
            Armored
            Double-Barrel Cannons Armed
            Micro-Rocket Launcher Armed
            */

            /*
            virtual
            : 부모 클래스의 자식 클래스에서 재정의될 수 있음을 표시
            : 기본적으로 부모 클래스의 메서드는 그대로 상속
            : 하지만 부모 클래스의 메서드 앞에 virtual을 붙이면, 자식 클래스가 같으 이름의 메서드를 override 키워드로 재정의 할 수 있게 허용

            override
            : 부모클래스의 virtual 메서드를 재정의(덮어쓰기)하는 데 사용
            : 부모 클래스의 메서드를 그대로 쓰지 않고 새로운 동작으로 바꾸기 위해 사용
            : 반드시 부모 클래스의 메서드가 virtual 또는 abstract 이어야 함

            base
            : 부모 클래스(상속한 클래스)의 멤버에 접근할 때 사용
            : base.Method -> 부모 클래스의 메서드 호출
            : base.Property -> 부모 클래스의 프로퍼티 접근
            : 생성자에서도 base(...) 형태로 부모 클래스 생성자 호출 가능
             */
        }
    }
}
