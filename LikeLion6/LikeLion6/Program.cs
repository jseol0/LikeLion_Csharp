using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion6
{
    internal class Program
    {
        /*
        class Person1
        {
            public string Name;
            public int Age;

            //기본생성자
            //클래스가 객체로 생성될떄 자동으로 실행되는 특별한 메서드
            //클래스와 같은 이름을 가지며, 반환형이 없다 (void도 사용하지 않음)
            //객체를 만들때 필요한 초기값을 설정할때 사용된다

            //
            public Person() {
                Name = "이름 없음";
                Age = 0;
                Console.WriteLine("기본 생성자가 실행됨");
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("기본 생성자가 실행됨");
            }
            

            // 위의 두개의 기본생성자를 기본값이 있는 기본생성자로 합침
            public Person(string name = "이름 없음", int age = 0)
            {
                Name = name;
                Age = age;
                Console.WriteLine("기본 생성자가 실행됨");
            }


            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
            }
        }
        */

        /* getter/setter 함수
        class Person
        {
            // 내부 변수
            private string Name;

            // 값 설정하기 (Setter)
            public void SetName(string newName)
            {
                Name = newName;
            }

            // 값 가져오기 (Getter)
            public string GetName()
            {
                return Name;
            }
        }
        */

        /* C#의 퍼로퍼티
        class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        */

        //프로퍼티 자동 구현
        class Person2
        {
            private int count = 100;
            public string Name { get; set; }
            public int Count
            {
                get { return count; }
            }

            public float Balance { get; private set; }

            public void AddBal()
            { 
                Balance += 100;
            }
        }

        static void Main(string[] args)
        {
            // C#에서 get/set 방식의 함수와 프로퍼티 비교
            
            /*  함수
            Person p = new Person();

            //p.Name = "jseol"      -> X
            p.SetName("jseol");
            Console.WriteLine(p.GetName());
            */

            //프로퍼티
            Person2 p = new Person2();
            p.Name = "jseol";
            p.AddBal();
            Console.WriteLine($"이름 {p.Name}, count : {p.Count}, Balace {p.Balance}" );
        }
    }
}
