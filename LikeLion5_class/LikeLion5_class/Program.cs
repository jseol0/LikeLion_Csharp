using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;


//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는것을 방지하기위해 사용된다
namespace dev1
{
    class MyClass
    {
        public static void sayHello() {
            Console.WriteLine("dev1 MyClass의 hello");
        }
    }
}

namespace LikeLion5_class
{
    internal class Program
    {
        //열거형(enum)
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현 가능
        enum DayOfWeek
        { 
            Sunday,     //0
            Monday,     //1
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        { 
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum Weapontype
        {
            Sword,
            Bow,
            Staff
        }

        // 구조체(struct)
        // 클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들때 사용
        struct Point
        {
            public int X;
            public int Y;

            //생성자 정의
            public Point(int x, int y)
            { 
                X = x;
                Y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }
        }

        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Student
        { 
            public string Name;
            public int Kor;
            public int Eng;
            public int Math;

            public void Print() { 
                Console.WriteLine($"{Name}\t{Kor}\t{Eng}\t{Math}");
            }
        }

        static void sayHello()
        {
            Console.WriteLine("ProgramClass의 hello");
        }


        static void ChooseWeaponType(Weapontype type) {
            if (type == Weapontype.Sword)
                Console.WriteLine("검을 선택했습니다.");
            else if (type == Weapontype.Bow)
                Console.WriteLine("활을 선택했습니다.");
            else if (type == Weapontype.Staff)
                Console.WriteLine("지팡이를 선택했습니다.");
        }

        static void Main(string[] args)
        {
            sayHello();
            dev1.MyClass.sayHello();

            //Math클래스 사용
            Console.WriteLine($"Pi : {Math.PI}");
            Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");

            //enum 선언
            DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);

            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);

            Weapontype type = Weapontype.Sword;
            ChooseWeaponType(type);
            type = Weapontype.Bow;
            ChooseWeaponType(type);
            type = Weapontype.Staff;
            ChooseWeaponType(type);

            //구조체 선언
            Point p = new Point(5, 15);
            p.Print();

            //var rect = new Rectangle { Width = 5, Height = 4 };
            Rectangle rect;
            rect.Width = 5;
            rect.Height = 4;
            Console.WriteLine($"Area : {rect.GetArea()}");

            Point[] points = new Point[2];
            points[0].X = 10;
            points[0].Y = 10;
            points[1].X = 20;
            points[1].Y = 20;

            foreach (var point in points)
            { 
                Console.WriteLine($"Point: ({point.X}, {point.Y})");
            }

            Student[] students = new Student[3];
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("이름, 국어, 영어, 수학 점수를 입력하시오 : ");
                students[i].Name = Console.ReadLine();
                students[i].Kor = int.Parse(Console.ReadLine());
                students[i].Eng = int.Parse(Console.ReadLine());
                students[i].Math = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름\t국어\t영어\t수학");
            for (int i = 0; i < 3; i++) {
                students[i].Print();
            }
            //foreach (var student in students) { 
            //    student.Print();
            //}
        }
    }
}
