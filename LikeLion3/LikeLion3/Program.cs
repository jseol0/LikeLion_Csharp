using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// switch문
            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말");
            //        break;
            //}


            //// 캐릭터를 선택하세여 (1검사 2마법사 3도적)
            //Console.WriteLine("캐릭터를 선택하세요 1.검사 2.마법사 3.도적");
            ////int Character = int.Parse(Console.ReadLine());
            //string Character = Console.ReadLine();
            //int att = 0;
            //int shild = 0;
            //bool check = false;

            //switch (Character)
            //{
            //    case "검사":
            //        att = 100;
            //        shild = 90;
            //        check = true;
            //        break;
            //    case "마법사":
            //        att = 110;
            //        shild = 80;
            //        check = true;
            //        break;
            //    case "도적":
            //        att = 115;
            //        shild = 70;
            //        check = true;
            //        break;
            //    default :
            //        check = false;
            //        Console.WriteLine("존재하지 않는 직업입니다");
            //        break;
            //}

            //if (check) {
            //    Console.WriteLine($"직업 : {Character}");
            //    Console.WriteLine($"공격력 : {att}");
            //    Console.WriteLine($"방어력 : {shild}");
            //}

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{ 
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int count = 0;

            //while (count < 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //// 랜덤
            //Random rand = new Random();

            //for (int i = 0; i < 10; ++i) {
            //    double randomNumber = rand.NextDouble();
            //    Console.WriteLine(randomNumber);
            //}            

            //대장장이 키우기
            //도끼 sss    10%
            //도끼 ss     40%
            //도끼 s      50%

            //Random rnd = new Random();

            //int randNum = 0;
            //for (int i = 0; i < 20; ++i) { 
            //    randNum = rnd.Next(1, 101);

            //    if (randNum >= 1 && randNum <= 10)
            //        Console.WriteLine("SSS");
            //    else if (randNum >= 11 && randNum <= 40)
            //        Console.WriteLine("SS");
            //    else
            //        Console.WriteLine("S");

            //    Thread.Sleep(500);  // 0.5초
            //}

            //// do while
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한 번 실행됩니다");
            //    x--;
            //} while (x > 0);

            //// break
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //// continue
            //for (int i= 1; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //// goto
            //int n = 1;

            //start:
            //if (n <= 5) {
            //    Console.WriteLine(n);
            //    n++;

            //    goto start;
            //}

            //Random random = new Random();

            //Console.WriteLine(" 대장장이 키우기 ");

            //int pmoney = 100;
            //int input;
            //int rnd;

            //Thread.Sleep(500);

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("1. 나무캐기 ");
            //    Console.WriteLine("2. 장비뽑기 ");
            //    Console.WriteLine("3. 나가기 ");
            //    Console.Write("입력 : ");
            //    input = int.Parse(Console.ReadLine());

            //    if (input == 1)
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("나무캐기(엔터)");
            //            Console.WriteLine("뒤로가기 x");

            //            string str = Console.ReadLine();

            //            if (str == "x")
            //            {
            //                Console.WriteLine("뒤로가기");
            //                break;
            //            }
            //            pmoney += 100;
            //            Console.WriteLine($"소지금 : {pmoney}");
            //        }
            //    }
            //    else if (input == 2)
            //    {
            //        if (pmoney >= 1000)
            //        {
            //            pmoney -= 1000;

            //            for (int i = 0; i < 20; i++)
            //            {
            //                rnd = random.Next(1, 101);

            //                if (rnd == 1)
            //                    Console.WriteLine("도끼등급 SSS");
            //                else if (rnd >= 2 && rnd <= 6)
            //                    Console.WriteLine("도끼등급 SS");
            //                else if (rnd >= 7 && rnd <= 17)
            //                    Console.WriteLine("도끼등급 S");
            //                else if (rnd >= 18 && rnd <= 38)
            //                    Console.WriteLine("도끼등급 A");
            //                else if (rnd >= 39 && rnd <= 69)
            //                    Console.WriteLine("도끼등급 B");
            //                else
            //                    Console.WriteLine("도끼등급 C");

            //                Thread.Sleep(500);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("돈이 부족합니다.\n");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else {
            //        Console.WriteLine("나갑니다.");
            //        Environment.Exit(0);
            //    }
            //}

            // 모험가 키우기
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 특수문자 인코딩문제

            //Random rand = new Random();

            //int gold = 500;
            //int health = 100;
            //int power = 10;
            //int input;
            //bool isAlive = true;

            //Console.WriteLine(" ⚔ 모험가 키우기 ⚔ ");
            //Thread.Sleep(1000);

            //while (isAlive) { 
            //    Console.Clear();
            //    Console.WriteLine($" 현재 상태 : 체력 {health} | 골드 {gold} | 공격력 {power}\n");
            //    Console.WriteLine("1. 탐험하기 ");
            //    Console.WriteLine("2. 장비 뽑기 (1000골드)");
            //    Console.WriteLine("3. 휴식하기 (체력 +20)");
            //    Console.WriteLine("4. 게임 종료 ");
            //    Console.Write("입력: ");

            //    input = int.Parse(Console.ReadLine());

            //    if (input == 1)
            //    {
            //        Console.Clear();
            //        Console.WriteLine(" 탐험을 떠납니다.");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다..");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다...");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다....");
            //        Thread.Sleep(500);

            //        int eventChance = rand.Next(1, 101);

            //        if (eventChance <= 30)
            //        {
            //            int damage = rand.Next(5, 21);
            //            Console.WriteLine($" 몬스터를 만났습니다! (체력 - {damage})");
            //            health -= damage;
            //        }
            //        else if (eventChance <= 70)
            //        {
            //            int reward = rand.Next(100, 301);
            //            Console.WriteLine($" 보물을 발견했습니다! (+{reward} 골드)");
            //            gold += reward;
            //        }
            //        else
            //        {
            //            int heal = rand.Next(10, 31);
            //            Console.WriteLine($" 신비한 약초를 발견했습니다! (+{heal} 체력)");
            //            health += heal;
            //        }

            //        if (health <= 0)
            //        {
            //            Console.WriteLine("\n 체력이 0이 되어 사망했습니다... 게임 오버");
            //            isAlive = false;
            //        }
            //        Thread.Sleep(1500);
            //    }
            //    else if (input == 2)
            //    {
            //        if (gold >= 1000)
            //        {
            //            gold -= 1000;
            //            Console.Clear();
            //            Console.WriteLine(" 장비를 뽑습니다...");
            //            Thread.Sleep(1000);

            //            int rnd = rand.Next(1, 101);

            //            if (rnd == 1)
            //            {
            //                Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
            //                power += 50;
            //            }
            //            else if (rnd <= 10)
            //            {
            //                Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
            //                power += 30;
            //            }
            //            else if (rnd <= 30)
            //            {
            //                Console.WriteLine("S급 희귀한 검 (공격력 +20) 획득!");
            //                power += 20;
            //            }
            //            else
            //            {
            //                Console.WriteLine("녹슨칼 (공격력 +5) 획득!");
            //                power += 5;
            //            }
            //            Thread.Sleep(1000);
            //        }
            //        else
            //        {
            //            Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else if (input == 3)
            //    {
            //        Console.WriteLine("휴식을 취합니다...(+20 체력)");
            //        health += 20;
            //        Thread.Sleep(1000);
            //    }
            //    else if (input == 4)
            //    {
            //        Console.WriteLine("게임을 종료합니다.");
            //        Environment.Exit(0);
            //    }
            //    else
            //    { 
            //        Console.WriteLine("잘못된 입력입니다. 다시 선택하세요");
            //        Thread.Sleep(1000);
            //    }
            //}



            ////콘솔 좌표

            ////콘솔 창 크기 설정 
            //Console.SetWindowSize(80, 25); //x 80 , y 25

            ////콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            //Console.SetBufferSize(80, 25);

            //Console.CursorVisible = false; //커서 숨기기


            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(0, 0);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.SetCursorPosition(0, 1);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 2);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 3);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 5);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 6);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 7);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 8);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 9);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 10);
            //Console.Write("┃                               대장장이 키우기                                ┃");
            //Console.SetCursorPosition(0, 11);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 12);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 13);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 14);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 15);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 16);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 17);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 18);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 19);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 20);
            //Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            //Thread.Sleep(3000);

            //for (int x = 0; x < 30; x++) { 
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 10);
            //    Console.Write("◎");
            //    Thread.Sleep(100);
            //}
            //Random rand = new Random();
            //int hp = 500;
            //int mp = 100;
            //int skilLv = 1;
            //int catchShoggoth = 0;
            //int slaveShoggoth = 0;
            //int deadShoggoth = 0;
            //int input;
            //bool isAlive = true;

            //Console.SetWindowSize(80, 26);
            //Console.SetBufferSize(80, 26);
            //Console.CursorVisible = false;


            //첫 로딩화면
            #region 첫 로딩화면
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                  Tekeli-li                                   ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 21);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 22);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 23);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 24);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 스토리 시작

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 20);
            Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.SetCursorPosition(0, 21);
            Console.Write("  태고의 시대.                                                                ");
            Console.SetCursorPosition(0, 22);
            Console.Write("  당신들은 올드 원이다.                                                       ");
            Console.SetCursorPosition(0, 23);
            Console.Write("  광대한 우주의 비밀을 쥐고, 창조와 파괴를 오락처럼 즐기던 존재.                 ");
            Console.SetCursorPosition(0, 24);
            Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.ReadLine();
            #endregion
        }
    }
}
