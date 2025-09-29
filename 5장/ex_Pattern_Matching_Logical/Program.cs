namespace ex_Pattern_Matching_Logical
{
    internal class Program
    {
        class OrderItem
        {
            public int Amount { get; set; }
            public int Price { get; set; }
        };

        static double GetPrice(OrderItem orderItem) => orderItem switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 } => 0.0,
            OrderItem { Amount: >= 100 } and OrderItem { Price: >= 10_000 } => orderItem.Amount * orderItem.Price * 0.8,
            not OrderItem { Amount: < 100 } => orderItem.Amount * orderItem.Price * 0.9,
            _ => orderItem.Amount * orderItem.Price,
        };

        static void Main(string[] args)
        {
            Console.WriteLine(GetPrice(new OrderItem { Amount = 0, Price = 10_000 }));  // 0
            Console.WriteLine(GetPrice(new OrderItem { Amount = 100, Price = 10_000 }));// 800000
            Console.WriteLine(GetPrice(new OrderItem { Amount = 100, Price = 9_000 })); // 810000
            Console.WriteLine(GetPrice(new OrderItem { Amount = 1, Price = 1_000 }));   // 1000

            /*
            논리패턴
            : 여러 패턴을 논리 연산자로 결합하거나 부정하는 기능
             */
        }
    }
}
