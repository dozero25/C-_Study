using System;
using static System.Console;

namespace ex_StringFormatNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수 : {0:D}", 123);             // 10진수 : 123
            WriteLine("10진수 : {0:D5}", 123);            // 10진수 : 00123

            // X : 16진수
            WriteLine("16진수 : 0x{0:X}", 0xFF1234);      // 16진수 : 0xFF1234
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);     // 16진수 : 0x00FF1234

            // N : 숫자
            WriteLine("숫자 : {0:N}", 123456789);         // 숫자 : 123,456,789.00
            WriteLine("숫자 : {0:N0}", 123456789);        // 숫자 : 123,456,789

            // F : 고정 소수점
            WriteLine("고정 소수점 : {0:F}", 123.45);     // 고정 소수점 : 123.45
            WriteLine("고정 소수점 : {0:F5}", 123.456);   // 고정 소수점 : 123.45600

            // E : 공학용
            WriteLine("공학용 : {0:E}", 123.456789);      // 공학용 : 1.234568E+002
        }
    }
}
