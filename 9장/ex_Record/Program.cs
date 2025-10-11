using System;
using System.Numerics;

namespace ex_Record
{
    record RTransaction
    { 
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From, -10} -> {To, -10} : ${Amount}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction 
            { 
                From = "Alice", 
                To = "Bob", 
                Amount = 100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Charlie",
                Amount = 200
            };

            Console.WriteLine(tr1); // Alice      -> Bob        : $100
            Console.WriteLine(tr2); // Alice      -> Charlie    : $200

            /*
            record
            : 불변 객체를 쉽게 만들기 위해 C# 9.0에 추가된 타입
             */
        }
    }
}
