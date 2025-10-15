using System;
using System.Collections;
using static System.Console;

namespace ex_UsingHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);

            /*
            one
            two
            three
            four
            five
             */

            /*
            메서드 / 프로퍼티	                설명	                        예제
            Add(object key, object value)	    새로운 키와 값을 추가	        ht.Add("apple", 1000);
            Remove(object key)	                지정한 키의 항목 제거	        ht.Remove("apple");
            ContainsKey(object key)	            해당 키가 있는지 확인	        ht.ContainsKey("apple");
            ContainsValue(object value)	        해당 값이 있는지 확인	        ht.ContainsValue(1000);
            Clear()	                            모든 항목 제거	                ht.Clear();
            Count	                            항목 수 반환	                ht.Count
            Keys	                            모든 키를 가져옴 (컬렉션 형태)	foreach (var k in ht.Keys)
            Values	                            모든 값을 가져옴 (컬렉션 형태)	foreach (var v in ht.Values)
            this[object key] (인덱서)	        키를 이용해 값 접근	            ht["apple"] = 1500;
             */
        }
    }
}
