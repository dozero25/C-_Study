using System;

namespace ex_ConstructorWithProperty
{
    class BirthdayInfo
    { 
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;            
            }
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(2000, 12, 2)
            };
            
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            /*
            Name : 서현
            Birthday : 2000-12-02 토
            Age : 25
             */


        }
    }
}
