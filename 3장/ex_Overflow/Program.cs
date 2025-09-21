using System;

namespace data_store_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);   // a = 4294967295

            a = a + 1;

            Console.WriteLine(a);   // a = 0 <- 오버플로우가 되면서 '0'으로 변경
        }
    }
}
