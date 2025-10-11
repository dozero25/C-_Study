namespace ex_InitOnly
{
    internal class Program
    {
        class Transaction
        {
            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public override string ToString()
            {
                return $"{From, -10} -> {To, -10} : ${Amount}";
            }
        }
        static void Main(string[] args)
        {
            Transaction tr1 = new Transaction { From = "Alice", To="Bob", Amount = 100};
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

            //tr3.Amount = 100; <- 오류 발생

            /*
            Alice      -> Bob        : $100
            Bob        -> Charlie    : $50
            Charlie    -> Alice      : $50
             */

            /*
            init
            : C# 9.0부터 추가된 프로퍼티 전용 접근자
            : 객체 초기화 시점에만 값을 설정할 수 있게 하는 문법
             */
        }
    }
}
