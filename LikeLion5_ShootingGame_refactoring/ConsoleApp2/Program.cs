using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion5_ShootingGame1
{
    struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //public int X { get { return x; } set { x = value; } }
        //public int Y { get { return y; } set { y = value; } }
    }

    class Program
    {
        static ConsoleKeyInfo keyInfo;
        static Point playerPos = new Point(0, 12);

        static string[] playerString = new string[] {
                "->",
                ">>>",
                "->"
        };

        static Stopwatch stopwatch = new Stopwatch();
        static long prevSecond, currentSecond;

        static void ReadInput(out bool isEscape)
        {
            isEscape = false;
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (playerPos.Y > 0) playerPos.Y--; break;
                    case ConsoleKey.DownArrow: if (playerPos.Y < Console.WindowHeight - 4) playerPos.Y++; break;
                    case ConsoleKey.LeftArrow: if (playerPos.X > 0) playerPos.X--; break;
                    case ConsoleKey.RightArrow: if (playerPos.X < Console.WindowWidth - 3) playerPos.X++; break;
                    case ConsoleKey.Spacebar:
                        Console.SetCursorPosition(playerPos.X + 2, playerPos.Y + 1);
                        Console.Write("미사일키");
                        break;
                    case ConsoleKey.Escape: isEscape = true; break;// ESC 키로 종료
                }
            }
        }

        static void Render()
        {
            if (currentSecond - prevSecond >= 100)
            {
                Console.Clear();
                prevSecond = currentSecond; // 이전 시간 업데이트

                for (int i = 0; i < playerString.Length; i++)
                {
                    Console.SetCursorPosition(playerPos.X, playerPos.Y + i);
                    Console.WriteLine(playerString[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            stopwatch.Start();
            prevSecond = stopwatch.ElapsedMilliseconds;
            bool isEscape = false;
            while (!isEscape)
            {
                currentSecond = stopwatch.ElapsedMilliseconds;
                ReadInput(out isEscape);
                Render();
            }
        }
    }
}