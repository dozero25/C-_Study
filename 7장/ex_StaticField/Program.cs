using System;

namespace ex_StaticField
{
    class Global {
        public static int Count = 0;
    }

    class ClassA {
        public ClassA() {
            Global.Count++;
        }
    }

    class ClassB {
        public ClassB() {
            Global.Count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");
            
            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");

            /*
            Global.Count : 0
            Global.Count : 4
             */
        }
    }
}
