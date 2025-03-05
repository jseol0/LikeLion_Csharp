using System;
using System.ComponentModel;

namespace BasicClass
{
    class Program
    {
        static void Main()
        {
            // 자료형
            // int, float, double, bool, char, string
            // 정수, 실수, 좀더 긴 실수, 참거짓, 낱말, 단어 혹은 문장

            //if문
            //if (조건이 성립) 실행
            //else (위 조건이 실행하지 않으면) 실행
            //if문 진짜 많이 씀

            /*
            int hp = 50;
            if (hp <= 0) Console.WriteLine("Game Over");
            else
            { 
                // 계속진행
            }
            */

            //int score = 0;

            //if (score <= 100)
            //    Console.WriteLine("레벨업");
            //else
            //    Console.WriteLine("노력필요");


            //int age = int.Parse(Console.ReadLine());
            //int age = 15;

            //if (age < 13)
            //    Console.WriteLine("어린이");
            //else if (age < 20)
            //    Console.WriteLine("청소년");
            //else
            //    Console.WriteLine("성인");


            //switch

            //string day = "목";

            //switch (day)
            //{
            //    case "월":
            //    case "화":
            //    case "수":
            //    case "목":
            //    case "금":
            //        Console.WriteLine("평일");
            //        break;
            //    case "토":
            //    case "일":
            //        Console.WriteLine("주말");
            //        break;
            //}


            //string grade = Console.ReadLine();

            //switch (grade) {
            //    case "A":
            //        Console.WriteLine("최고");
            //        break;
            //    case "B":
            //        Console.WriteLine("좋음");
            //        break;
            //    case "C":
            //        Console.WriteLine("보통");
            //        break;
            //    case "D":
            //        Console.WriteLine("탈락");
            //        break;
            //}

            //int month = int.Parse(Console.ReadLine());

            //switch (month) {
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("가을");
            //        break;
            //    default:
            //        Console.WriteLine("잘못 입력되었습니다");
            //        break;
            //}



            // 반복믄
            // for(초기화; 조건; 증감식)
            //  반복될 내용
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //    sum += i;
            //Console.WriteLine(sum);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}