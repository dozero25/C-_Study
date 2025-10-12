using System;

namespace ex_InitizlizingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo"};

            Console.WriteLine("array1...");

            foreach (string greeting in array1)
                Console.WriteLine($"{greeting}");

            Console.WriteLine("array2...");
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            foreach (string greeting in array2)
                Console.WriteLine($"{greeting}");

            Console.WriteLine("array3...");
            string[] array3 = { "안녕", "Hello", "Halo" };
            foreach (string greeting in array3)
                Console.WriteLine($"{greeting}");

            /*
            array1...
            안녕
            Hello
            Halo
            array2...
            안녕
            Hello
            Halo
            array3...
            안녕
            Hello
            Halo
             */
        }
    }
}
