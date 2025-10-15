using System;
using System.Collections;

namespace ex_UsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0) 
                Console.WriteLine(stack.Pop());

            /*
            5
            4
            3
            2
            1
             */

            /*
            Push(T item)	    스택 맨 위에 요소 추가	                                stack.Push(10);
            Pop()	            스택의 맨 위 요소 제거 + 반환 (비었으면 예외)	        int x = stack.Pop();
            Peek()	            스택의 맨 위 요소 확인 (제거 안 함)	                    int x = stack.Peek();
            Clear()	            모든 요소 제거	                                        stack.Clear();
            Contains(T item)	특정 값 존재 여부 확인	                                stack.Contains(10);
            ToArray()	        스택을 배열로 변환 (맨 위 요소가 배열의 첫 번째로 감)	int[] arr = stack.ToArray();
            TrimExcess()	    메모리 최적화 (Capacity와 Count 차이 최소화)	        stack.TrimExcess();
            Count (프로퍼티)	현재 요소 개수	                                        int n = stack.Count;
             */
        }
    }
}
