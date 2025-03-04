using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion7_2
{
    internal class Program
    {
        //제네릭 사용하기(Generics)
        //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있ek
        class Cup<T>
        { 
            public T Content { get; set; }
        }

        class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


        static void Main(string[] args)
        {
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee"};
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine(cupOfString.Content);
            //Console.WriteLine(cupOfInt.Content);

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            ////IEnumerator
            ////C#컬렌션 순회 반복할수 있는 인터페이스
            ////컬렉션을 직접 제어하며 순회할 수 있음
            ////foreach 없이도 컬렉션 순회 가능
            ////LINQ나 커스텀 컬렉션을 만들 때 유용함 ->유니티에서 다시 보쟈
            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator();  // 열거자 가져오기
            //while (enumerator.MoveNext())
            //{ 
            //    Console.WriteLine(enumerator.Current);
            //}

            //var collection = new SimpleCollection();

            //foreach (var i in collection)
            //{
            //    Console.WriteLine(i);
            //}


            ////Dictionary
            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach (var pair in ages)
            //{ 
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}


            ////null
            ////참조 형식은 null을 가질 수 있으며, 값 형식은 기본적으로 null을 가질 수 없다
            //string str = null;

            //if (str == null)
            //    Console.WriteLine("str is null");

            ////int num = null; Error
            //// 억지로 값 형식에 null을 줄수 있긴하다
            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            ////null 값을 다루는 연산자 ?? , ?. 연산자
            //// ?? 연산자를 사용해 null 인 경우 대체값을 제공, ?. 은 null 안전 접근을 한다
            //string str = null;

            //Console.WriteLine(str ?? "DefaultValue");   // str이 null 이면 "DefaultValue"
            ///*
            //if (str != null)
            //{
            //    System.Console.WriteLine(str);
            //}
            //else
            //{
            //    System.Console.WriteLine("DafaultValue");
            //}
            //*/

            //str = "Hello";

            //Console.WriteLine(str?.Length); // str이 null 이 아니면 실행 아니면 패스
            ///* 위 코드와 같다
            // if (str != null)
            //{
            //    str.Length;
            //}
            //*/


            //LINQ
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있다
            //LINQ는 확장 메서드 형태로 제공된다
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var item in evenNumbers)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
