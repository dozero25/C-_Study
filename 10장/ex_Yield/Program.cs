using System;
using System.Collections;

namespace ex_Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };

        public IEnumerator GetEnumerator()
        { 
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);

            /*
            1
            2
            3
            */

            /*
            
             */
        }
    }
}
