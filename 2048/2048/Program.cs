using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class CheckerBoard
    {
        public int[,] board = new int[4, 4];
        public int count = 0;

        public CheckerBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    board[i, j] = 0;
            }

            board[0, 2] = 2;
            board[2, 0] = 2;
        }


        public void DrawBoard()
        {
            Console.Clear();

            string topBorder = "     ┌──────┬──────┬──────┬──────┐";
            string midBorder = "     ├──────┼──────┼──────┼──────┤";
            string bottomBorder = "     └──────┴──────┴──────┴──────┘";

            Console.WriteLine("\n\t\t2  0  4  8\n");
            Console.WriteLine(topBorder);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("     │");
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] != 0)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" {board[i, j],4}");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" │");
                }
                Console.WriteLine();

                if (i < 3)
                {
                    Console.WriteLine(midBorder);
                }
            }

            Console.WriteLine(bottomBorder);
        }

        public void MoveNumber(ConsoleKey key)
        {
            Console.Clear(); // 키 입력이 있을 때만 화면 초기화
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    MoveVertical(0);
                    InputRandomNumber();
                    break;
                case ConsoleKey.DownArrow:
                    MoveVertical(1);
                    InputRandomNumber();
                    break;
                case ConsoleKey.LeftArrow:
                    MoveHorizontal(0);
                    InputRandomNumber();
                    break;
                case ConsoleKey.RightArrow:
                    MoveHorizontal(1);
                    InputRandomNumber();
                    break;
            }
            

            if (CheckFinish())
            {
                DrawBoard();
                Console.WriteLine("\nCongratulations! You've reached 2048!");
                Environment.Exit(0);
            }

            DrawBoard(); // 이동 후 보드 출력
        }

        private bool CheckFinish()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == 2048)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckGameOver()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == 0)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i < 3 && board[i, j] == board[i + 1, j]) || // 아래쪽 검사
                        (j < 3 && board[i, j] == board[i, j + 1]))   // 오른쪽 검사
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void InputRandomNumber()
        {
            Random rand = new Random();
            int x, y;

            while (true)
            {
                x = rand.Next(0, 4);
                y = rand.Next(0, 4);

                if (board[x, y] == 0)
                {
                    board[x, y] = 2;
                    break;
                }
            }

            if (CheckGameOver())
            {
                DrawBoard();
                Console.WriteLine("\nGame Over! Try again.");
                Environment.Exit(0);
            }
        }

        private void MoveVertical(int direction)
        {
            if (direction == 0) //up
            {
                for (int j = 0; j < 4; j++)
                {
                    int[] tmp = new int[4];
                    int index = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (board[i, j] == 0)
                            continue;

                        if (index > 0 && tmp[index - 1] == board[i, j])
                        {
                            tmp[index - 1] *= 2;
                        }
                        else
                        {
                            tmp[index] = board[i, j];
                            index++;
                        }
                    }

                    for (int i = 0; i < 4; i++)
                        board[i, j] = tmp[i];
                }
            }
            else      // down
            {
                for (int j = 0; j < 4; j++)
                {
                    int[] tmp = new int[4];
                    int index = 3;

                    for (int i = 3; i >= 0; i--)
                    {
                        if (board[i, j] == 0)
                            continue;

                        if (index < 3 && tmp[index + 1] == board[i, j])
                        {
                            tmp[index + 1] *= 2;
                        }
                        else
                        {
                            tmp[index] = board[i, j];
                            index--;
                        }
                    }

                    for (int i = 3; i >= 0; i--)
                        board[i, j] = tmp[i];
                }
            }
        }

        private void MoveHorizontal(int direction)
        {
            if (direction == 0) // left
            {
                for (int i = 0; i < 4; i++)
                {
                    int[] tmp = new int[4];
                    int index = 0;
                    
                    for (int j = 0; j < 4; j++)
                    { 
                        if (board[i, j] == 0)
                            continue;

                        if (index > 0 && tmp[index - 1] == board[i, j])
                        {
                            tmp[index - 1] *= 2;
                        }
                        else
                        {
                            tmp[index] = board[i, j];
                            index++;
                        }
                    }
                    for (int j = 0; j < 4; j++)
                        board[i, j] = tmp[j];
                }
            }
            else       // right
            {
                for (int i = 0; i < 4; i++)
                {
                    int[] tmp = new int[4];
                    int index = 3;

                    for (int j = 3; j >= 0; j--)
                    {
                        if (board[i, j] == 0)
                            continue;

                        if (index < 3 && tmp[index + 1] == board[i, j])
                        {
                            tmp[index + 1] *= 2;
                        }
                        else
                        {
                            tmp[index] = board[i, j];
                            index--;
                        }
                    }
                    for (int j = 3; j >= 0; j--)
                        board[i, j] = tmp[j];
                }
            }
        }
    }

    internal class Program
    {
        static ConsoleKeyInfo keyInfo;
        static void Main(string[] args)
        {
            Console.Title = "2048 C# version";
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 15);

            CheckerBoard checkerBoard = new CheckerBoard();
            checkerBoard.DrawBoard();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    checkerBoard.MoveNumber(keyInfo.Key);
                }
            }
        }
    }
}
