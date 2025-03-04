using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LikeLion7
{
    //클래스시그니처 기본구성
    //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다

    //[접근 지정자] [수정자] calss 클래스이름 : 부모클래스, 인터페이스
    //public        abstract
    //privte        sealed
    //protected     static
    //              parial

    public class Player
    { 
        public string Name { get; set; }
        public int Score { get; set; }
    }

    //상속하는 클래스
    public class Warrior : Player
    { 
        public int Strength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    //public class Enemy : IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }
    //}

    //추상클래스
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 환경변수 사용하기
            //Console.WriteLine("Exiting the program...");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0 );

            //Random
            //Random rand = new Random();

            //int randomNum = rand.Next(1, 100);
            //Console.WriteLine(randomNum);

            //프로그램 실행 시간 구하기
            //Stopwatch sw = Stopwatch.StartNew();

            //for (int i = 0; i < int.MaxValue; i++)
            //{ 
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

            // 정규식
            //string input = "123-456-7890";

            //string pattern = @"^\d{3}-\d{3}-\d{4}$";
            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"Is valid phone number: {isMatch}");

            ////값 형식과 참조 형식
            ////값 형식은 스택에 저장되고, 참조형식은 힙에 저장된다
            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}");
            //Console.WriteLine($"ReferenceType : {referenceType}");

            ////박싱 언박싱
            ////값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value;
            //int unboxed = (int)boxed;

            //Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");

            ////is 연산자 형식 비교하기
            ////객체가 특정 형식인지 확인할수 있다
            //object obj = "Hello";

            //Console.WriteLine(obj is string);
            //Console.WriteLine(obj is int);

            ////as 연산자로 형식 변환하기
            //string str = obj as string;

            //Console.WriteLine(str);
            //object obj = 42;
            //var obj2 = 42;


            //if (obj is int number)
            //{
            //    Console.WriteLine($"Number : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}

            ////문자열 다루기
            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); //Hello,Alice

            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열

            ////string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome : { text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awecome' with 'great' : {text.Replace("awesome", "great")}");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //int iterations = 10000;
            //Stopwatch sw = Stopwatch.StartNew();
            //string text = "";
            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}
            //sw.Stop();
            //Console.WriteLine($"String: {sw.ElapsedMilliseconds} ms");      //7ms

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}
            //sw.Stop();
            //Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds} ms");   //0ms

            //예외처리하기
            //try catch
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]);  // error
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("프로그램이 중단되지 않고 실행합니다");

            ////finally 블록은 예외 발생여부와 상관없이 항상 실행된다
            //try
            //{
            //    int num = int.Parse("NotANumber");  //error
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("항상 실행됩니다");
            //}

            ////Exceoption 클래스
            ////모든 예외의 기본클래스
            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}

            ////throw 구문으로 직접 예외 발생시키기
            //try
            //{
            //    int age = -5;
            //    if (age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            ////배열과 컬렉션
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach (var num in numbers)
            //    Console.WriteLine(num);

            ////list
            ////배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //    Console.WriteLine(name);

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach (int i in list)
            //    Console.WriteLine(i);

            //list.Insert(1, 100);

            //foreach (int i in list)
            //    Console.WriteLine(i);   //1 100 2 3


            ////Stack
            ////LIFO(Last-In, First-Out) 구조 (후입선출)
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{ 
            //    Console.WriteLine(stack.Pop());     // 3 2 1
            //}


            ////Queue
            ////FIFO(First-In, First-Out) 구조 (선입선출)
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{ 
            //    Console.WriteLine(queue.Dequeue());     // 1 2 3
            //}


            ////ArrayList
            ////크기가 동적으로 조정되는 배열로, 다양한 형식의 데이터를 저장할 수 있다
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);

            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{ 
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(1);

            //Console.WriteLine("\nArrayList 요소 제거 후: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            ////Hashtable 클래스
            ////키-값 쌍을 저장하는 컬렉션, 키를 이용해 값을 빠르게 검색
            //Hashtable hashtable = new Hashtable();

            ////키-값
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소: ");
            //foreach (DictionaryEntry entry in hashtable)
            //{ 
            //    Console.WriteLine($"key : {entry.Key}, value : {entry.Value}");
            //}

            //Console.WriteLine($"\nAlice의 나이: {hashtable["Alice"]}");    // 25
            
            //hashtable.Remove("Bob");
            //Console.WriteLine("\n요소 제거 후 Hashtable:");
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
        }
    }
}            
