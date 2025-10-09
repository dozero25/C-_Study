using System;

namespace ex_MultiInterfaceInferitance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    { 
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();  // Run! Run!
            car.Fly();  // Fly! Fly!

            IRunnable runable = car as IRunnable;
            runable.Run();  // Run! Run!

            IFlyable flyable = car as IFlyable;
            flyable.Fly();  // Fly! Fly!

            /*
            | 구분        | as                                                | new              
            | 의미        | 기존 객체를 형변환                                | 새로운 객체 생성          
            | 역할        | 이미 만들어진 인스턴스를 다른 타입으로 보는 것    | 새로운 메모리 공간에 객체를 만드는 것 
            | 메모리 변화 | 기존 객체 그대로 (참조만 바뀜)                    | 새로운 인스턴스 생성 (새 메모리 할당)  
            | 실패 시     | 변환 불가능하면 `null` 반환                       | 실패 개념 없음 (무조건 새 객체 생성)  

             */
        }
    }
}
