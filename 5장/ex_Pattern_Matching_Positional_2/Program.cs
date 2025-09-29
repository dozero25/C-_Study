namespace ex_Pattern_Matching_Positional_2
{
    internal class Program
    {
        struct Audience {
            public bool IsCitizen{ get; init; }
            public int Age{ get; init; }

            public Audience(bool isCitizen, int age) {
                IsCitizen = isCitizen;
                Age = age;
            }

            public void Deconstruct(out bool isCitizen, out int age) { 
                isCitizen = IsCitizen;
                age = Age;
            }
        }
        static void Main(string[] args)
        {
            var CalculateFee = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            Console.WriteLine($"내국인: {a1.IsCitizen}  나이 : {a1.Age} 요금 : {CalculateFee(a1)}");
            // 내국인: True  나이 : 10 요금 : 100
            var a2 = new Audience(false, 30);
            Console.WriteLine($"내국인: {a2.IsCitizen}  나이 : {a2.Age} 요금 : {CalculateFee(a2)}");
            // 내국인: False  나이 : 30 요금 : 400
        }
    }
}
