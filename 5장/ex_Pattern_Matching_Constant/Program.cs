namespace ex_Pattern_Matching_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _=> throw new ArgumentException("Not supported Code")
            };

            Console.WriteLine(GetCountryCode("KR"));    // 82
            Console.WriteLine(GetCountryCode("US"));    // 1
            Console.WriteLine(GetCountryCode("UK"));    // 44

            /*
            상수패턴
            : 값이 특정 상수(리터럴, enum, null 등)와 일치하는지 검사
            : 값이 이 상수와 같으면 해당 분기로 이동

            is 키워드
            int value = 10;

            if (value is 10)
            {
                Console.WriteLine("값이 10입니다.");
            }
            else
            {
                Console.WriteLine("값이 10이 아닙니다.");
            }

            switch 문
            int number = 5;

            string result = number switch
            {
                1 => "하나",
                2 => "둘",
                5 => "다섯",
                _ => "그 외"
            };

            Console.WriteLine(result);


             */
        }
    }
}
