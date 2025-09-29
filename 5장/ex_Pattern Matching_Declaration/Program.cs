namespace ex_Pattern_Matching_Declaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object foo = 23;

            if (foo is int bar) {   // 1. foo가 int인 경우 2. foo를 int 형식으로 변환하여 bar에 할당
                Console.WriteLine(bar); // 23
            } else {
                Console.WriteLine("foo is not int");
            }

            /*
            선언 패턴
            : is 키워드와 같이 사용하여 값의 타입을 검사하면서 동시에 변수를 선언
             */
        }
    }
}
