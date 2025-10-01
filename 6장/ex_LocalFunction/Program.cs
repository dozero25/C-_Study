using System;

namespace ex_LocalFunction
{
    internal class Program
    {
        static string ToLowerString(string input) { 
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i) // 로컬함수
            {
                if (arr[i] < 65 || arr[i] > 90)
                {
                    return arr[i];
                }
                else { 
                    return (char)(arr[i] + 32);
                }
            }

            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello"));
            Console.WriteLine(ToLowerString("Good Morning.."));
            Console.WriteLine(ToLowerString("This is C#"));

            /*
            hello
            good morning..
            this is c#
             */

            /*
            로컬 함수
            : 정의된 메서드 내부에서만 접근이 가능
            : 다른 클래스나 메서드에서 호출 불가
            : 캡슐화 -> 외부에 노출 x, 코드 유지
            : 
             */
        }
    }
}
