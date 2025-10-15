using System;
using System.Collections;

namespace ex_UsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++)
                list.Add(i);

            foreach(int i in list)
                Console.Write($"{i} "); // 0 1 2 3 4
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object i in list)
                Console.Write($"{i} "); // 0 1 3 4
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object i in list)
                Console.Write($"{i} "); // 0 1 2 3 4
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");   // 0 1 2 3 4 abc def
            Console.WriteLine();
        }
    }
}
