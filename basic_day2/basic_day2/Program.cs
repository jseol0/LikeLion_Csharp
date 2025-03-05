using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 2중 for문 이용해 구구단 출력
            //for (int i = 1; i <= 9; i++)
            //{ 
            //    for (int j = 2; j <= 9; j++)
            //        Console.Write($"{j} X {i} = {i * j}\t");
            //}

            //int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i++);
            //}

            //while 문으로 1에서 10까지의 합 구하기
            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{ 
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            // 가위바위보 게임 만들기
            // (if or switch), while 문 이용하기
            // 나는 1~3번으로 선택해서 가위바위보를 선택 상대는 랜덤으로 가위바위보

            //Random rnd = new Random();
            //int myInput = 0;
            //int comInput = 0;
            //string[] s = { "", "묵", "찌", "빠" };

            //while (true)
            //{
            //    Console.WriteLine("1, 2, 3 중 하나를 입력해 주세요 (1:묵, 2:찌 3:빠)");

            //    try
            //    {
            //        myInput = int.Parse(Console.ReadLine());
            //        comInput = rnd.Next(1, 4);
            //    }
            //    catch(FormatException)
            //    {
            //        Console.WriteLine("잘못된 입력입니다");
            //        continue;
            //    }

            //    switch (myInput)
            //    {
            //        case 1:
            //            {
            //                Console.WriteLine($"myInput: {s[myInput]} comInput: {s[comInput]}");
            //                if (comInput == 1)
            //                    Console.WriteLine("Draw");
            //                else if (comInput == 2)
            //                    Console.WriteLine("Win");
            //                else
            //                    Console.WriteLine("lose");
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine($"myInput: {s[myInput]} comInput: {s[comInput]}");
            //                if (comInput == 1)
            //                    Console.WriteLine("lose");
            //                else if (comInput == 2)
            //                    Console.WriteLine("Draw");
            //                else
            //                    Console.WriteLine("Win");
            //                break;
            //            }
            //        case 3:
            //            {
            //                Console.WriteLine($"myInput: {s[myInput]} comInput: {s[comInput]}");
            //                if (comInput == 1)
            //                    Console.WriteLine("Win");
            //                else if (comInput == 2)
            //                    Console.WriteLine("lose");
            //                else
            //                    Console.WriteLine("Draw");
            //                break;
            //            }
            //        case 4:
            //            {
            //                Console.WriteLine("게임을 종료합니다");
            //                return;
            //            }
            //        default:
            //            Console.WriteLine("잘못된 입력입니다");
            //            break;
            //    }
            //    Console.WriteLine();
            //}


            //숫자야구게임
            //컴퓨터가 랜덤하게 1 ~ 100 까지 숫자를 내가 10번안에 맞추는게임

            Random rnd = new Random();
            bool isWin = false;
            int com = rnd.Next(1, 101);
            int input = 0;

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("1 ~ 100 중 입력하세요 :");

                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 입력입니다 숫자를 입력하세요");
                    continue;
                }

                if (input < 1 && input > 100)
                {
                    Console.WriteLine("잘못된 입력입니다 1 ~ 100 중 입력하세요");
                    continue ;
                }

                if (input == com)
                {
                    Console.WriteLine("맞았습니다!!");
                    isWin = true;
                    break;
                }
                else
                {
                    Console.WriteLine("틀렸습니다");
                    if (input > com)
                        Console.WriteLine($"{input} 보다 작습니다");
                    else
                        Console.WriteLine($"{input} 보다 큽니다");
                }
                i++;
            }
            if (!isWin)
                Console.WriteLine($"실패했습니다 정답은 {com} 입니다");
        }
    }
}
