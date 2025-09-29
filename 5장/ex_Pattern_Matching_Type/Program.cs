using System.Linq.Expressions;

namespace ex_Pattern_Matching_Type
{
    class Prescholer();
    class Underage();
    class Adult();
    class Senior();


    internal class Program
    {
        static int CalculateFee(object visitor) { 
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException($"Prohibited age : {visitor.GetType()}", nameof(visitor))
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Fee for a senior : {CalculateFee(new Senior())}");
            Console.WriteLine($"Fee for a adult : {CalculateFee(new Adult())}");
            Console.WriteLine($"Fee for a underage : {CalculateFee(new Underage())}");
            Console.WriteLine($"Fee for a prescholer : {CalculateFee(new Prescholer())}");

            /*
            Fee for a senior : 200
            Fee for a adult : 500
            Fee for a underage : 100
            Unhandled exception. System.ArgumentException: Prohibited age : ex_Pattern_Matching_Type.Prescholer (Parameter 'vistor')
               at ex_Pattern_Matching_Type.Program.CalculateFee(Object vistor) in C:\dozero\c#_study\5장\ex_Pattern_Matching_Type\Program.cs:line 19
               at ex_Pattern_Matching_Type.Program.Main(String[] args) in C:\dozero\c#_study\5장\ex_Pattern_Matching_Type\Program.cs:line 28

            마지막은 오류 발생 -> Prescholer 타입은 패턴 매칭에 해당하는 타입이 없기 때문
             */

            /*
            형식패턴
            : c#에서 자주 사용하는 문법
            : 객체의 런타입을 검사하고, 그 타입이 맞으면 지정된 변수에 바인딩하는 패턴
            : 값이 타입이면 이렇게 처리하고 아니면 다른 방식으로 처리

            기본 문법
            : is 키워드와 함께 -> if(obj is int number) {...}
            : switch 식과 함께 -> obj switch { int number => ... , string text => ... , _ => ... }
             */
        }
    }
}
