using System;

namespace ex_StringNumberConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);   // 123

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);   // 3.14

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);   // 123456

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);   // 1.2345
        }
    }
}
