using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;    //using 이용해 다른 네임스페이스 가져오기

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}

namespace LikeLion9
{
    class Person
    {
        private string Name; // 외부 접근 제한

        public void SetName(string n)
        {
            Name = n;
        }

        public string GetName()
        {
            return Name;
        }
    }

    class MyResource
    {
        //소멸자
        ~MyResource()
        {
            Console.WriteLine("삭제될떄 호출");
        }
    }


    //추상클래스 (Abstract Class)
    //추상클래스는 객체를 생성할수 없는 클래스로, 상속을 통해서만 사용할수 있다
    //공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할때 사용됨
    //abstract 키워드를 사용
    //추상 메서드는 선언만 하고, 구현은 하지 않는다
    //상속받은 클래스는 반드시 구현해야 한다
    abstract class Animal
    {
        //추상 메서드(구현x, 상속받은 클래스가 구현)
        public abstract void MakeSound();

        //일반 메서드
        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다");
        }
    }

    //추상클래스를 상속받아 구체적인 클래스 구현
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹~");
        }
    }


    ////부모클래스의 생성자 호출
    //class Parent
    //{
    //    public Parent(string message)
    //    {
    //        Console.WriteLine($"부모생성자 {message}");
    //    }
    //}

    //class Child : Parent
    //{
    //    public Child() : base("성공") // 부모생성자 호출
    //    {
    //        Console.WriteLine("자식생성자 호출");
    //    }
    //}

    class Parent
    {
        protected string name;

        public Parent(string name)
        { 
            this.name = name;
            Console.WriteLine($"부모생성자: {name}");
        }
    }

    class Child : Parent
    {
        private int age;

        //부모생성자를 호출하면서 name 전달 + age 초기화
        public Child(string name, int age) : base(name)
        { 
            this.age = age;
            Console.WriteLine($"자식생성자: 나이 = {age}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {name}, 나이: {age}");
        }
    }

    internal class Program
    {
        //메서드 ref, out
        //ref 포인터개념 참조
        static void Increase(ref int x) { x++; }

        //out은 반환이 여러개일때 유용하다
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a; 
            y = b;
        }

        static int Add(int x) { return x + 1; }

        static void Main(string[] args)
        {
            //Hello.Say s = new Hello.Say();
            //s.SayHello();

            ////using Hello;
            //Say say = new Say();
            //say.SayHello();

            /* private 이기때문에 접근 불가
            p.Name = "Alice"; //필드에 값넣기
            Console.WriteLine(p.Name);
            */
            //Person p = new Person();
            //p.SetName("Alice");
            //Console.WriteLine(p.GetName());

            //MyResource r= new MyResource();

            //int a = 10;
            //Increase(ref a);
            //Console.WriteLine(a);

            //int b = 20;
            //int x, y;
            //OutFunc(a, b, out x, out y);
            //Console.WriteLine($"x: {x} y: {y}");

            //Animal myDog = new Dog();
            //Animal myCat = new Cat();

            //myDog.MakeSound();
            //myCat.MakeSound();

            //Child child = new Child();
            Child child = new Child("홍길동", 25);
            child.ShowInfo();
        }
    }
}
