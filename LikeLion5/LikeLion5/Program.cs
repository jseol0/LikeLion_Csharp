using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion5
{
    internal class Program
    {
        //전역변수
        static int num2 = 20;


        //1.매개변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");

        }
        //2.매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3.반환값만 있는 함수
        static int GetNumber()
        {

            return 42;
        }

        //4.매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }


        //5.기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6.함수 오버로딩(Overloading)
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //7.out 키워드 (여러 값을 반환할때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        { 
            quotient = a / b;
            remainder = a % b;
        }

        //8.ref 키워드 (값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }

        //params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num; 
            }
            return total;
        }

        //재귀함수 (자기자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }

        //화살표 함수 => 람다 표현식 이라고도 하며
        //간결한 방식으로 함수를 정의할 수 있다.
        static int Add1(int a, int b) {
            return a + b;
        }

        static int Add2(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Greet();
            Greet("철수");

            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(Multiply(2.5, 4.5));

            int q, r;
            Divide(10, 3, out q, out r);
            Console.WriteLine($"몫 : {q}, 나머지 : {r}");

            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);

            Console.WriteLine(Sum(1, 2, 3));

            Console.WriteLine(Add1(3, 5));
            Console.WriteLine(Add2(3, 5));
        }
    }
}
