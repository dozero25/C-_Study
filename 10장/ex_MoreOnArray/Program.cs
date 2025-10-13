using System;

namespace ex_MoreOnArray
{
   
    internal class Program
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        { 
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int r in scores)
            {
                Console.Write($"{r} "); // 80 74 81 90 34
            }
            Console.WriteLine();

            // 배열 오름차순
            Array.Sort( scores );

            // 모든 요소를 print 메서드로 출력
            Array.ForEach<int>(scores, new Action<int>(Print)); // 34 74 80 81 90
            Console.WriteLine();

            // 배열의 차원 수 출력(1차원 배열이므로 1)
            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // Number of dimensions : 1

            // 정렬된 배열에서 81을 가진 이진탐색 (Binary Search)
            Console.WriteLine($"Binary Serach : 81 is at {Array.BinarySearch<int>(scores, 81)}");   // Binary Serach : 81 is at 3

            // 배열에서 90의 인덱스를 선형탐색(Linear Search)
            Console.WriteLine($"Linear Serach : 90 is at {Array.IndexOf(scores, 90)}"); // Linear Serach : 90 is at 4

            // 모든 요소가 60 이상인지 검사
            Console.WriteLine($"Everyone passed ? {Array.TrueForAll<int>(scores, CheckPassed)}");   // Everyone passed ? False

            // 60점 미만인 첫 번째 요소의 인덱스 찾기 (람다식)
            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;

            // 다시 모두 통과했는지 확인
            Console.WriteLine($"Everyone passed ? {Array.TrueForAll<int>(scores, CheckPassed)}");   // Everyone passed ? True

            // 현재 배열 길이 출력
            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");    // Old length of scores : 5

            // 배열 크기를 10으로 변경
            // 기존 데이터 유지, 새 공간은 0
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");   // New length of scores : 10

            // 변경된 배열 전체 출력
            Array.ForEach<int>(scores, new Action<int>(Print)); Console.WriteLine();// 61 74 80 81 90 0 0 0 0 0
            Console.WriteLine();

            // 배열의 3번 인덱스부터 7개 요소를 0으로 초기화
            Array.Clear(scores, 3, 7);
            Array.ForEach(scores, new Action<int>(Print));  // 61 74 80 0 0 0 0 0 0 0
            Console.WriteLine();

            // 배열의 앞 3개 요소만 잘라서 새로운 배열에 복사
            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print)); // 61 74 80
            Console.WriteLine();
        }
    }
}
