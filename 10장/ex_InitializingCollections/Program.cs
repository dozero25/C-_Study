using System;
using System.Collections;
using static System.Console;

namespace ex_InitializingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                WriteLine($"Queue : {item}");
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            /*
            ArrayList : 123
            ArrayList : 456
            ArrayList : 789

            Stack : 789
            Stack : 456
            Stack : 123

            Queue : 123
            Queue : 456
            Queue : 789

            ArrayList : 11
            ArrayList : 22
            ArrayList : 33
             */
        }
    }
}
