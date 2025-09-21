using static System.Console;

namespace ex_StringModify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());                    // ToLower() : 'abc'
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());                    // ToUpper() : 'ABC'

            WriteLine();

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny "));// Insert() : 'Happy Sunny  Friday!'
            WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));     // Remove() : 'I Love You'

            WriteLine();

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());                  // Trim() : 'No Spaces'
            WriteLine("TrimStart() : '{0}'", " No Spaces".TrimStart());         // TrimStart() : 'No Spaces'
            WriteLine("TrimEnd() : '{0}'", "No Spaces ".TrimEnd());             // TrimEnd() : 'No Spaces'


            /*
            ToLower() : 문자열의 대문자를 소문자로 변환
            ToUpper() : 문자열의 소문자를 대문자로 변환
            Insert() : 문자열의 지정된 위치에 지정된 문자열이 삽입
            Remove() : 문자열읠 지정된 위치로부터 지정된 수만큼 문자열 삭제
            Trim() : 문자열 앞 뒤 공백 제거
            TrimStart() : 문자열 앞 공백 제거
            TrimEnd() : 문자열 뒤 공백 제거
             */
        }
    }
}
