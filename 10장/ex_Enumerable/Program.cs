using System;
using System.Collections;

namespace ex_Enumerable
{
    internal class Program
    {
        class MyList : IEnumerator, IEnumerable
        {
            private int[] array;
            int position = -1;

            public MyList()
            {
                array = new int[3];
            }

            public int this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    if (index >= array.Length)
                    {
                        Array.Resize<int>(ref array, index + 1);
                        Console.WriteLine($"Array Resized : {array.Length}");
                    }
                    array[index] = value;
                }
            }

            public object Current
            {
                get
                {
                    return array[position];
                }
            }

            public bool MoveNext()
            {

                if (position == array.Length - 1)
                {
                    Reset();
                    return false;
                }
                position++;
                return (position < array.Length);
            }

            public void Reset()
            {
                position = -1;
            }
            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int i in list)
                Console.WriteLine(i);

            /*
            Array Resized : 4
            Array Resized : 5
            0
            1
            2
            3
            4
             */

            /*
            IEnumerable	        GetEnumerator()를 제공해서 foreach 시작 가능하게 함	                public IEnumerator GetEnumerator() { return this; }
            IEnumerator	        실제로 순회(MoveNext), 현재값(Current), 초기화(Reset)를 담당	    MoveNext(), Reset(), Current 구현
             */
        }
    }
}
