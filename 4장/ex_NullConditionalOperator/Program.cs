using System.Collections;
using static System.Console;

namespace ex_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구");   // a가 null이면 Add 메서드를 호출하지 않음
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");   // Count :
            WriteLine($"{a?[0]}");              //
            WriteLine($"{a?[1]}");              //

            a = new ArrayList();    // 더 이상 null이 아님
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");   // Count : 2
            WriteLine($"{a?[0]}");              // 야구
            WriteLine($"{a?[1]}");              // 축구

            /*
            ?.는 null일 수도 있는데, null이면 그냥 넘어가고 싶다 라는 상황에서 사용하는 안전장치
            특히 계층 구조가 깊은 객체 접근이나 이벤트 호출에서 사용
             */
        }
    }
}
