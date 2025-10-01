using System;

namespace ex_OptionalParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone = "") { 
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("종근");
            PrintProfile("관순", "010-111-1111");
            PrintProfile(name : "봉근");
            PrintProfile(name : "동주", phone : "010-222-2222");

            /*
            Name: 종근, Phone:
            Name: 관순, Phone: 010-111-1111
            Name: 봉근, Phone:
            Name: 동주, Phone: 010-222-2222
             */
        }
    }
}
