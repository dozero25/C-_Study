using System;

namespace ex_AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = DateTime.MinValue;

        public int Age
        {
            get {
                if (Name == "Unknown" || Birthday == DateTime.MinValue) 
                    return 0;

                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            /*
            Name : Unknown
            Birthday : 0001-01-01 월
            Age : 0
             */

            birth.Name = "서현";
            birth.Birthday = new DateTime(1997, 4, 8);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            /*
            Name : 서현
            Birthday : 1997-04-08 화
            Age : 29
             */
        }
    }
}
