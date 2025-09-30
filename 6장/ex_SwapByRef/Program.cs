namespace ex_SwapByRef
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");    // Before Swap: x = 3, y = 4

            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");     // After Swap: x = 4, y = 3

            /*
            c# - ref 키워드
            : C#에서 ref 키워드는 메서드에 인수를 참조로 전달할 때 사용
            : 기본적으로 C#에서는 메서드에 인수를 값으로 전달. 즉, 메서드가 호출될 때 인수의 복사본이 전달
            : 그러나 ref 키워드를 사용하면 메서드가 인수의 실제 메모리 위치를 참조하게 되어, 메서드 내에서 인수의 값을 변경하면 호출한 쪽에서도 그 변경 사항이 반영

            값을 변경할 때 무조건 사용해야하나?
            : 아님

            : 1. 값 타입(숫자, 구조체) → 원본을 바꾸려면 ref 필요

            : 2. 참조 타입(클래스, 배열, List) → 내부 값 변경은 ref 필요 없음

            : 3. 참조 타입이라도 참조 자체(=다른 객체를 할당)를 바꾸려면 ref 필요


            1. 값 타입

            void Increase(ref int a)  // 참조 전달
            {
                a++;
            }

            int x = 10;
            Increase(ref x);
            Console.WriteLine(x); // 11 (변경됨)

            2. 참조 타입
            void AddItem(List<int> list)
            {
                list.Add(100);
            }

            var numbers = new List<int> { 1, 2, 3 };
            AddItem(numbers);

            Console.WriteLine(string.Join(", ", numbers)); 
            // 1, 2, 3, 100 (변경됨)


            3. 참조 타입에서 참조 자체 변경
            void ReplaceList(ref List<int> list)
            {
                list = new List<int> { 9, 9, 9 }; // 새로운 객체를 할당
            }

            var numbers = new List<int> { 1, 2, 3 };
            ReplaceList(ref numbers);

            Console.WriteLine(string.Join(", ", numbers)); 
            // 9, 9, 9 (참조가 교체됨)


             */
        }
    }
}
