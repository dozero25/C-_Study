using System;

namespace ex_DerivedFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type Of array : {array.GetType()}");
            Console.WriteLine($"Base type Of array : {array.GetType().BaseType}");

            /*
            Type Of array : System.Int32[]
            Base type Of array : System.Array
             */
        }
    }
}
