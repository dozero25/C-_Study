using System;

namespace ex_NamedParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone) { 
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-6543", name: "박지성");
            PrintProfile("박세리", "010-111-1111");
            PrintProfile("박상현", phone: "010-222-2222");

            /*
            Name: 박찬호, Phone: 010-123-1234
            Name: 박지성, Phone: 010-987-6543
            Name: 박세리, Phone: 010-111-1111
            Name: 박상현, Phone: 010-222-2222
             */
        }
    }
}
