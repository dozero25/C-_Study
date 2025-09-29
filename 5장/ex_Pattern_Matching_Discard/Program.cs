namespace ex_Pattern_Matching_Discard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GetCountryCode = (string nation) => nation switch
            {
                "US" => 1,
                "KR" => 82,
                "UK" => 44,
                _ => throw new ArgumentException("Not supported Code")
            };

            Console.WriteLine(GetCountryCode("US"));    // 1
            Console.WriteLine(GetCountryCode("KR"));    // 82
            Console.WriteLine(GetCountryCode("UK"));    // 44
            Console.WriteLine(GetCountryCode("EU"));    // Exception: Not supported Code

            /*
            무시패턴
            : 무시패턴(_)은 값을 검사하지 않고 버리틑 패턴
            : 패턴 매칭 시 특정 갑이나 변수를 신경쓰지 않겠다는 의미
             */
        }
    }
}
