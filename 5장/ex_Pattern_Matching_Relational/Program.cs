namespace ex_Pattern_Matching_Relational
{
    internal class Program
    {
        static string GetGrade(double score) => score switch
        {
            < 60 => "F",
            >= 60 and < 70 => "D",
            >= 70 and < 80 => "C",
            >= 80 and < 90 => "B",
            _=> "A"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(GetGrade(85));    // B
            Console.WriteLine(GetGrade(92));    // A
            Console.WriteLine(GetGrade(79));    // C

            /*
            관계 패턴
            : <, <=, >, >= 연산자를 사용하여 값이 특정 범위 내에 있는지 확인

            is 연산자
            int score = 85;

            if (score is >= 90)
                Console.WriteLine("A 학점");
            else if (score is >= 80)
                Console.WriteLine("B 학점");
            else if (score is >= 70)
                Console.WriteLine("C 학점");
            else
                Console.WriteLine("F 학점");

            switch 문
            static string GetGrade(int score) => score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _     => "F"
            };

            Console.WriteLine(GetGrade(95));  // A
            Console.WriteLine(GetGrade(72));  // C
            Console.WriteLine(GetGrade(50));  // F
             */
        }
    }
}
