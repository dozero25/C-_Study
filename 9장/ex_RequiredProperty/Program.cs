using System;

namespace ex_RequiredProperty
{
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }

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
            BirthdayInfo birth = new BirthdayInfo() { Name = "지윤", Birthday = new DateTime(2012, 9, 12) };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            /*
            Name : 지윤
            Birthday : 2012-09-12 수
            Age : 14
             */

            /*
            required
            : 프로퍼티 초기화를 강제하는 키워드
            : 초기화가 필요한 프로퍼티를 초기화하지 않는 실수를 방지
             */
        }
    }
}
