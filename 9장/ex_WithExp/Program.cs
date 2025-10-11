using System;

namespace ex_WithExp
{
    record RTransacton
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
            RTransacton tr1 = new RTransacton { From="Alice", To="Bob", Amount=100 };
            RTransacton tr2 = tr1 with { To = "Charlie" };
            RTransacton tr3 = tr2 with { From = "Dave", Amount = 30 };

            Console.WriteLine(tr1); // Alice      -> Bob        : $100
            Console.WriteLine(tr2); // Alice      -> Charlie    : $100
            Console.WriteLine(tr3); // Dave       -> Charlie    : $30

            /*
            with
            : 복사하면서 일부 속성만 변경
             */
        }
    }
}
