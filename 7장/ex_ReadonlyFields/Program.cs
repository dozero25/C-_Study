namespace ex_ReadonlyFields
{
    internal class Program
    {
        class Configuration
        {
            private readonly int min;
            private readonly int max;

            public Configuration(int v1, int v2)
            { 
                min = v1;
                max = v2;
            }

            public void ChangeMax(int newMax)
            {
                max = newMax; // error CS0191: 읽기 전용 필드에는 할당할 수 없습니다. 단, 필드가 정의된 형식의 생성자 또는 초기값 전용 setter 변수 이니셜라이저에서는 예외입니다.
            }
         }
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
