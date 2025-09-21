using System;
using static System.Console;

namespace ex_StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));            // IndexOf 'Good' : 0
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));                  // IndexOf 'o' : 1
            WriteLine();

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));    // LastIndexOf 'Good' : 0
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf('o'));       // LastIndexOf 'Good' : 6
            WriteLine();

            // StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));      // StartsWith 'Good' : True
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));// StartsWith 'Morning' : False
            WriteLine();

            // EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));          // EndsWith 'Good' : False
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));    // EndsWith 'Morning' : True
            WriteLine();

            // Contains()
            WriteLine("Contains 'Good' : {0}", greeting.Contains("Good"));          // Contains 'Good' : True
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));    // Contains 'Morning' : True
            WriteLine();

            // Replace()
            WriteLine("Replace  'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));    // Replace  'Morning' with 'Evening': Good Evening


            /*
            1. IndexOf()
            - 특정 문자열 또는 문자가 처음 등장하는 위치를 반환
            - 반환 값 : int 찻지 못하면 -1

            2. LastIndexOf()
            - 특정 문자열 또는 문자가 마짐가으로 등장하는 위치를 반환
            - 반환값 : int 찾지 못하면 -1

            3. StartsWith()
            - 문자열이 특정 문자열로 시작하는지 여부를 확인
            - 반환값 : bool

            4. EndsWith()
            - 문자열이 특정 문자열로 끝나는지 여부를 확인
            - 반환값 : bool

            5. Contains()
            - 문자열 안에 특정 문자열이 존재하는지 여부를 확인
            - 반환값 : bool

            6. Replace()
            - 문자열 안의 특정 문자열을 다른 문자열로 치환
            - 반환값 : string

             */
        }
    }
}
