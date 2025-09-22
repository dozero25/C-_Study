using System;

namespace ex_StringConcatenate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";
            Console.WriteLine(result);  // 123456

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);  // Hello World!
        }
    }
}
