namespace ex_Pattern_Matching_Property
{
    internal class Program
    {
        class Car { 
            public String Model { get; set; }
            public DateTime ProducedAt { get; set; }
        }

        static string GetNickname(Car car)
        {
            var GenerateMessage = (Car car, string nickname) => $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
            {
                return GenerateMessage(car, "Fastback");
            }
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
            {
                return GenerateMessage(car, "Cobra II");
            }
            else
            {
                return GenerateMessage(car, "Unknown");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetNickname(new Car { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));
            // Mustang produced in 1967 is Fastback
            Console.WriteLine(GetNickname(new Car { Model = "Mustang", ProducedAt = new DateTime(1976, 6, 7) }));
            // Mustang produced in 1976 is Cobra II
            Console.WriteLine(GetNickname(new Car { Model = "Mustang", ProducedAt = new DateTime(2099, 12, 25) }));
            // Mustang produced in 2099 is Unknown

            /*
            프로퍼티 패턴
            : 객체의 특정 프로퍼티 값이 조건을 만족하는지 검사하는 패턴
            : 객체의 타입뿐 아니라 속성 값도 함께 비교할 때 사용하는 패턴


            단일 프로퍼티 검사
            if (obj is Person { Age: 18 })
            {
                Console.WriteLine("성인식 대상자입니다.");
            }

            다중 프로퍼티 검사
            if (obj is Person { Age: >= 18, Name: "Alice" })
            {
                Console.WriteLine("성인 Alice입니다.");
            }

            switch 문
            string GetCategory(Person p) => p switch
            {
                { Age: < 13 } => "어린이",
                { Age: >= 13 and < 20 } => "청소년",
                { Age: >= 20 and < 65 } => "성인",
                { Age: >= 65 } => "노인",
                _ => "알 수 없음"
            };




             */

        }
    }
}
