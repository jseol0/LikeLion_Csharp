using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Omok
{
    class GameManager
    {
        private Board board;
        private AIPlayer aiPlayer;
        private const char PlayerStone = 'O';
        private const char AIStone = 'X';

        public GameManager()
        {
            board = new Board();
            aiPlayer = new AIPlayer();
        }

        public void Play()
        {
            bool isPlayerTurn = true;

            while (true)
            {
                board.Print();

                if (isPlayerTurn)
                {
                    Console.WriteLine("플레이어 턴입니다. (O)");
                    Console.WriteLine("행과 열을 공백으로 구분하여 입력하시오 (ex) 1 1)");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input)) continue;

                    string[] tokens = input.Split();
                    if (tokens.Length < 2
                        || !int.TryParse(tokens[0], out int row)
                        || !int.TryParse(tokens[1], out int col))
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해 주세요.");
                        continue;
                    }

                    if (!board.IsValidCoord(row, col))
                    {
                        Console.WriteLine("좌표가 보드범위를 벗어났습니다.");
                        continue;
                    }

                    if (!board.PlaceStone(row, col, PlayerStone))
                    {
                        Console.WriteLine("해당 칸은 이미 돌이 놓여있습니다.");
                        continue;
                    }
                }
                else
                {
                    //AI 차례
                    Console.WriteLine("AI의 차례입니다. (X)");
                    var move = aiPlayer.GetMove(board);
                    if (move.row == -1)
                    {
                        Console.WriteLine("빈 칸이 없어 게임을 종료합니다.");
                        break;
                    }

                    Console.WriteLine($"AI가 ({move.row}, {move.col})에 돌을 놓습니다.");
                    board.PlaceStone(move.row, move.col, AIStone);
                    Thread.Sleep(1000);
                }
                char currentStone = isPlayerTurn ? PlayerStone : AIStone;
                if (board.CheckWin(currentStone))
                {
                    board.Print();
                    if (isPlayerTurn)
                        Console.WriteLine("축하합니다 당신이 승리했습니다.");
                    else
                        Console.WriteLine("AI가 승리했습니다");
                    break;
                }

                if (board.GetEmptyCells().Count == 0)
                {
                    board.Print();
                    Console.WriteLine("무승부입니다");
                    break;

                }

                isPlayerTurn = !isPlayerTurn;
            }

            Console.WriteLine("게임 종료");
            Console.ReadKey();
        }
    }
}
