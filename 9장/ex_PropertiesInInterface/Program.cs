using System;

namespace ex_PropertiesInInterface
{
    internal class Program
    {
        interface INamedValue
        { 
            string Name
            {
                get;
                set;
            }
            string Value
            {
                get;
                set;
            }
        }
        class NameValue : INamedValue
        {
            public string Name 
            { 
                get; 
                set; 
            }
            public string Value 
            { 
                get; 
                set; 
            }
        }

        static void Main(string[] args)
        {
            NameValue name = new NameValue() { Name = "이름", Value = "박상현" };
            NameValue height = new NameValue() { Name = "키", Value = "177cm" };
            NameValue weight = new NameValue() { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");

            /*
            이름 : 박상현
            키 : 177cm
            몸무게 : 90kg
             */

        }
    }
}
