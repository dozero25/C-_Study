using System;
using System.Globalization;
using static System.Console;

namespace ex_StringFormatDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 09, 21, 23, 18, 22);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}",dt); // 12시간 형식 : 2025-09-21 오후 11:18:22 (일)
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);  // 24시간 형식 : 2025-09-21 23:18:22 (일요일)

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();

            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));   // 2025-09-21 오후 11:18:22 (일)
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));     // 2025-09-21 23:18:22 (일요일)
            WriteLine(dt.ToString(ciKo));                                   // 2025-09-21 일 오후 11:18:22

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
             
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));   // 2025-09-21 PM 11:18:22 (Sun)
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));     // 2025-09-21 23:18:22 (Sunday)
            WriteLine(dt.ToString(ciEn));                                   // 9/21/2025 11:18:22 PM
        }
    }
}
