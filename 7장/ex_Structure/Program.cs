using System;

namespace ex_Structure
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z)
        { 
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString()); // 10, 20, 40

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.Z = 500;

            Console.WriteLine(p3d2.ToString()); // 100, 200, 300
            Console.WriteLine(p3d3.ToString()); // 100, 200, 500

            /*
            struct 구조체
            : 값 형식(Value Type)으로 데이터를 담는 타입
            : 주로 작고 독립적인 데이터 묶음을 표현할 때 사용

            특징	            구조체(struct)	                                    클래스(class)
            형식	            값 형식(Value Type)	                                참조 형식(Reference Type)
            저장 위치	        스택(Stack) 또는 값이 포함된 위치에 직접 저장	    힙(Heap)에 객체 저장, 참조만 스택에 저장
            복사	            값 복사 → 복사본이 독립적으로 존재	                참조 복사 → 같은 객체를 가리킴
            상속	            다른 구조체/클래스 상속 불가                        상속 가능
                                하지만 인터페이스 구현 가능	
            기본 생성자	        사용자가 정의하지 않아도 필드를 0으로 초기화	    사용자가 정의하지 않으면 기본 생성자 자동 제공
            가비지 컬렉션	    불필요 (스택에 저장되므로 스코프 종료 시 해제)	    필요 (힙의 객체를 GC가 관리)
            크기	            작고 가벼운 데이터에 적합	                        복잡하고 큰 데이터에 적합
             */
        }
    }
}
