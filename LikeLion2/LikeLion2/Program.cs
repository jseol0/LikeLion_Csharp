using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 이진수 다루기
            //// 이진수를 정수로 변환
            //Console.Write("이진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();   // 0101
            //int decimalValue = Convert.ToInt32(binaryInput, 2);    // (입력값, 2진수로)

            //// 정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");


            ////var 키워드
            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");


            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리형 기본값 : {defaultBool}");


            // 연산자
            //1.학점평균계산기
            //Console.Write("국어 : ");
            //int lang = int.Parse(Console.ReadLine());
            //Console.Write("영어 : ");
            //int eng = int.Parse(Console.ReadLine());
            //Console.Write("수학 : ");
            //int mat = int.Parse(Console.ReadLine());

            //int sum = lang + eng + mat;
            //double ever = (double)sum / 3.0;

            //Console.WriteLine($"총점 : {sum}, 평균 : {ever:F2}");


            ////2. 비트 반전 연산자
            //Console.WriteLine("정수를 입력하시오: ");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine(~input);
            //string binaryOutput = Convert.ToString(~input, 2);

            //Console.WriteLine(binaryOutput);

            //int x = 5, y = 10;

            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);  // true
            //Console.WriteLine(x > y);  // false
            //Console.WriteLine(x <= y);  // true
            //Console.WriteLine(x >= y);  // false


            //조건문

            //가지고 있는 소지금을 입력하세요:
            // 0 ~ 100 무한의대검
            // 101 ~ 200 카타나
            // 201 ~ 300 진은검
            // 301 ~ 400 집판검
            // 401 ~ 500 엑스칼리버
            // 501 ~ 600 유령검

            //Console.Write("소지금을 입력하세요 : ");

            //string weapon;
            //int att = 0;
            //int gold = int.Parse(Console.ReadLine());
            //if (gold > 600) {
            //    weapon = "전설의검";
            //    att = 7;
            //}
            //else if (gold > 500)
            //{
            //    weapon = "유령검";
            //    att = 6;
            //}
            //else if (gold > 400)
            //{
            //    weapon = "엑스칼리버";
            //    att = 5;
            //}
            //else if (gold > 300)
            //{
            //    weapon = "집판검";
            //    att = 4;
            //}
            //else if (gold > 200)
            //{
            //    weapon = "진은검";
            //    att = 3;
            //}
            //else if (gold > 100)
            //{
            //    weapon = "카타나";
            //    att = 2;
            //}
            //else
            //{
            //    weapon = "무한의대검";
            //    att = 1;
            //}

            //Console.WriteLine("캐릭터 : 멋사검존");
            //Console.WriteLine($"무기 : {weapon}");
            //Console.WriteLine($"공격력 : 100 + {att}");

            //1
            int x, y, z;
            Console.WriteLine("세 정수를 입력하세요");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            int max = x > y ? (x > z ? x : y > z ? y : z) : (y > z ? y : x > z ? x : z);
            Console.WriteLine($"최대값 : {max}");

            //2
            Console.WriteLine("점수를 입력하세요");
            int input = int.Parse(Console.ReadLine());

            if (input > 90)
                Console.WriteLine("A");
            else if (input > 80)
                Console.WriteLine("B");
            else if (input > 70)
                Console.WriteLine("C");
            else if (input > 60)
                Console.WriteLine("D");
            else 
                Console.WriteLine("F");

            //3
            double a, b;
            string opt;
            double result;
            Console.Write("숫자1 을 입력하세요 : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("숫자2 을 입력하세요 : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요 : ");
            opt = Console.ReadLine();

            if (opt == "+")
                result = a + b;
            else if (opt == "-")
                result = a - b;
            else if (opt == "*")
                result = a * b;
            else if (opt == "/")
            {
                if (b == 0)
                    Console.WriteLine("0 으로는 나눌 수 없습니다.");
                result = a / b;
            }
            else {
                Console.WriteLine("잘못된 연산자를 입력했습니다.");
                return;
            }
            
            if (!(opt == "/" && b == 0))
                Console.WriteLine($"결과 : {result}");
        }
    }
}
