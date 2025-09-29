namespace ex_Pattern_Matching_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GetStatistics = (List<object[]> records) =>
            {
                var statistics = new Dictionary<string, int>();

                foreach (var record in records)
                {
                    var (contentType, contentViews) = record switch
                    {
                        [_, "COMEDY", .., var views] => ("COMEDY", views),
                        [_, "SF", .., var views] => ("SF", views),
                        [_, "ACTION", .., var views] => ("ACTION", views),
                        [_, .., var amount] => ("ETC", amount),
                        _ => ("ERC", 0)
                    };

                    if (statistics.ContainsKey(contentType)) statistics[contentType] += (int)contentViews;
                    else statistics.Add(contentType, (int)contentViews);

                }
                return statistics;

            };

            List<object[]> MovieRecords = new List<object[]>
            {
                new object[] { 0, "COMEDY", "Spy", 10_000 },
                new object[] { 1, "COMEDY", "Scary Movie", 20_000 },
                new object[] { 2, "SF", "Avengers: Inifinte War", 100_000 },
                new object[] { 3, "COMEDY", "극한직업", 25_000 },
                new object[] { 4, "SF", "Star Wars : A New Hope", 200_000 },
                new object[] { 5, "ACTION", "Fast & Furious", 80_000 },
                new object[] { 6, "DRAMA", "Notting Hill", 1_000 },
            };

            var statistics = GetStatistics(MovieRecords);

            foreach (var s in statistics)
            {
                Console.WriteLine($"{s.Key} : {s.Value}");
            }
            /*
            COMEDY : 55000
            SF : 300000
            ACTION : 80000
            ETC : 1000
             */

            /*
            목록 패턴
            : 배열, 리스트, 시퀀스 등 컬렉션의 구조와 요소를 검사할 때 사용하는 패턴

            기본 문법
            int[] numbers = { 1, 2, 3 };

            if (numbers is [1, 2, 3])
            {
                Console.WriteLine("배열이 [1,2,3]과 동일합니다.");
            }

            무시 패턴 사용
            int[] numbers = { 1, 2, 3, 4 };

            if (numbers is [1, 2, ..])
            {
                Console.WriteLine("배열이 1,2로 시작합니다.");
            }
            ..(스파인디스크 연산자) 또는 _를 사용해서 나머지 요소 무시 가능

            
            switch문 
            int[] numbers = { 1, 2, 3 };

            string result = numbers switch
            {
                [1, 2, 3] => "첫 번째 배열",
                [1, 2, ..] => "1,2로 시작하는 배열",
                [] => "빈 배열",
                _ => "기타"
            };

            Console.WriteLine(result);  // 첫 번째 배열


            위치 패턴 + 논리 패턴
            int[] numbers = { 5, 10, 15 };

            if (numbers is [>= 0, >= 0, >= 0])
            {
                Console.WriteLine("모든 요소가 0 이상입니다.");
            }


             */
        }
    }
}
