using System;
using static System.Console;

namespace ex_StringSlice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting.Substring(0, 5));    // Good
            WriteLine(greeting.Substring(5));       // Morning
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None); 
            WriteLine("Word Count : {0}", arr.Length);  // Word Count : 2

            foreach (string str in arr) {
                WriteLine("{0}", str);
                /*
                 Good
                 Morning
                 */
            }

            /*
            StringSplitOptions.None : 빈 문자열도 배열에 포함
            StringSplitOptions.RemoveEmptyEntries : 빈 문자열은 제외
             
             */
        }
    }
}
