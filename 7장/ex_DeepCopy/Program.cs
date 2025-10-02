using System;

namespace ex_DeepCopy
{
    internal class Program
    {
        class MyClass {
            public int MyField1;
            public int MyField2;

            public MyClass DeepCopy() {
                MyClass newCopy = new MyClass();
                newCopy.MyField1 = this.MyField1;
                newCopy.MyField2 = this.MyField2;

                return newCopy;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");  // 10 30
                Console.WriteLine($"{target.MyField1} {target.MyField2}");  // 10 30

                /*
                얕은 복사
                : 객체를 복사할 때 객체의 값은 그대로 복사하지만, 객체 안의 참조형 멤버는 '주소만' 복사
                : 원본 객체와 복사본이 같은 참조형 데이터를 공유

                특징
                : 값형 멤버(int, double, bool) → 값 자체 복사
                : 참조형 멤버(string 제외, class 객체) → 주소만 복사
                : 원본/복사본 중 하나에서 참조형 데이터를 변경하면 둘 다 영향을 받음
                 */

            }

            Console.WriteLine("DeepCopy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");  // 10 20
                Console.WriteLine($"{target.MyField1} {target.MyField2}");  // 10 30

                /*
                깊은 복사
                : 객체와 그 안의 모든 참조형 데이터까지 완전히 새롭게 복사
                : 원본과 복사본이 서로 완전히 독립적

                특징
                : 원본 객체를 바꿔도 복사본에는 영향 없음
                : 수동으로 재귀적 복사 또는 직렬화/역직렬화를 통해 구현 가능
                 */
            }
        }
    }
}
