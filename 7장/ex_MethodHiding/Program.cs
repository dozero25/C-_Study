using System;

namespace ex_MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base MyMethod");
        }
    }

    class Derived : Base
    {
        public new void MyMethod() // 메서드 숨기기
        {
            Console.WriteLine("Derived MyMethod()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();     // Base MyMethod

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();  // Derived MyMethod()

            Base baseOrDrived = new Derived();
            baseOrDrived.MyMethod();// Base MyMethod

            /*
            메서드 숨기기
            : 부모 클래스의 메서드를 자식 클래스에서 새로 정의하여 덮어 쓰는 것 처럼 보이지만, 실제로는 오버라이딩이 아닌 별개의 메서드를 정의하는 것을 말함

            : 오버라이딩 -> 부모의 메서드를 재정의(런타임 타형성)
            : 숨기기 -> 부모의 메서드를 가림(컴파일 타임 바인딩)

            오버라이딩
            : 호출 시점 -> 런타임
            : 키워드 -> oeverride(부모는 virtual 필요)
            : 다형성 -> 지원
            : 사용 목적 -> 부모 메서드 재정의

            메서드 숨기기
            : 호출 시점 -> 컴파일 타임
            : 키워드 -> new
            : 다형성 -> 미지원
            : 사용 목적 -> 부모 메서드를 가림(이름만 가지고 별개의 메서드)
             */
        }
    }
}
