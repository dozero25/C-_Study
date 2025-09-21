namespace ex_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT); // 2147483647
            Console.WriteLine(MIN_INT); // -2147483648

            /*
             const int a = 3;
             a = 4; <- 오류 발생

             const는 상수이기 때문에 절대로 변하지 않는 값
             그래서 상수인 a를 변경하면 오류가 발생
             */


        }
    }
}
