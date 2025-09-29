namespace ex_Pattern_Matching_Parenthesized
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object age = 30;
            if (age is (int and > 19))
                Console.WriteLine("Major"); // Major

            /*
            괄호 패턴
            : 패턴식을 ()로 감싸서 우선순위를 명확히 하거나 가독성을 높이는 패턴
             */
        }
    }
}
