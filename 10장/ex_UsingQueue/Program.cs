using System;
using System.Collections;

namespace ex_UsingQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());

            /*
            1
            2
            3
            4
            5
             */

            /*
            Enqueue(T item) 	큐의 끝에 요소를 추가	                                queue.Enqueue("A");
            Dequeue()	        큐의 맨 앞 요소를 제거하고 반환. 큐가 비면 예외 발생	string x = queue.Dequeue();
            Peek()	            큐의 맨 앞 요소를 제거하지 않고 반환	                string x = queue.Peek();
            Clear()	            모든 요소 제거	                                        queue.Clear();
            Contains(T item)	특정 요소가 있는지 확인	                                queue.Contains("B")
            ToArray()	        큐의 요소를 배열로 복사	                                string[] arr = queue.ToArray();
            TrimExcess()	    메모리 최적화 (Capacity와 Count 차이 줄임)	            queue.TrimExcess();
            Count (프로퍼티)	큐 안의 요소 개수	                                    int n = queue.Count;
             */
        }
    }
}
