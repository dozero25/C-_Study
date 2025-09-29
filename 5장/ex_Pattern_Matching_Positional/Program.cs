namespace ex_Pattern_Matching_Positional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<String, int> itemPrice = new Tuple<string, int>("espresso", 3000);

            if (itemPrice is ("espresso", < 5000))
            {
                Console.WriteLine("The coffee is affordable");  // The coffee is affordable
            }

            /*
            위치 패턴
            : 튜플이나 레코드 타입의 요소를 순서대로 검사하는 패턴

            기본 문법
            (int, int) point = (3, 5);

            if (point is (3, 5))
            {
                Console.WriteLine("x=3, y=5입니다.");
            }

            레코드 위치 패턴
            record Person(string Name, int Age);

            Person p = new Person("Alice", 25);

            if (p is ("Alice", 25))
            {
                Console.WriteLine("Alice, 25세 입니다.");
            }

            관계 패턴과 결합
            (int, int) point = (10, 20);

            if (point is (>0, >0))
            {
                Console.WriteLine("1사분면");
            }

            switch문 
            var point = (3, 4);

            string quadrant = point switch
            {
                ( >0, >0) => "1사분면",
                ( <0, >0) => "2사분면",
                ( <0, <0) => "3사분면",
                ( >0, <0) => "4사분면",
                _         => "축 위"
            };

            Console.WriteLine(quadrant);  // 1사분면
             */


        }
    }
}
