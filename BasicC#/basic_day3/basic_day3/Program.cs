using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_day3
{
    public class Board
    {
        public int[,] board = new int[3, 3] {
            { 0, 0, 0},
            { 0, 0, 0},
            { 0, 0, 0}
        };

        public void InputNum(int x, int y) { board[x, y] = 1; }

        public void RenderBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public bool CheckBingo()
        {
            int countX = 0;
            int countY = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                        countX++;
                    if (board[j, i] == 1)
                        countY++;
                }
                if (countX == 3 || countY == 3)
                    return true;
                countX = 0;
                countY = 0;
            }

            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ////배열: Array = "정렬된 것들"
            //int[] score = { 100, 90, 80 };
            //string[] names = { "철수", "영희", "민수" };

            //int형 정수를 5번 입력받아서, 1차원 배열에 저장후
            //배열에 저장된 모든 값의 합을 계산하는 알고리즘

            //int[] numbers = new int[5];
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //1차원 배열에 저장된 정수 {12, 45, 7, 34, 22}의 정수중
            //최대값과 최소값을 찾아 각각 출력하는 프로그램을 만들어주세요
            //int[] numbers = new int[] { 12, 45, 7, 34, 22 };
            //int max = numbers.Max();
            //int min = numbers.Min();
            //Console.WriteLine($"max : {max} min : {min}");

            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    if (max < numbers[i])
            //        max = numbers[i];
            //    if (min > numbers[i])
            //        min = numbers[i];
            //}
            //Console.WriteLine($"max : {max} min : {min}");


            //// List<int> vs int[]
            //// int[] numbers[] = new int[길이];
            //// List<형식>     -길이는 가변적으로 내가 원하는만큼 사용할수 있다.

            ////내가 길이를 알고있다 -> 배열
            ////얼마나 될진 모르겠지만 배열은 써야됨 -> List
            //List<int> numbers = new List<int>();
            //numbers.Add(0);
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(6);

            ////List 는 .Length 대신 .Count를 사용
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // 1차원 배열에 저장된 정수를 역순으로 출력하는 프로그램을 만들어주세요
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);

            //numbers.Reverse();
            //for (int i = 0; i < numbers.Count; i++)
            //    Console.WriteLine(numbers[i]);

            //for (int i = numbers.Count - 1; i >= 0; i--)
            //    Console.WriteLine(numbers[i]);

            ////foreach
            //numbers.ForEach(x => Console.WriteLine(x));


            ////2차원배열
            ////퍼즐 <= 2차원배열 정복해야되
            //int[,] array = {
            //    { 1, 2, 3},
            //    { 4, 5, 6},
            //    { 7, 8, 9}
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(array[i, j]);
            //    Console.WriteLine();
            //}

            ////2차원 배열 각 행과 열의 합을 따로 출력하는 프로그램을 만들어 주세요
            ////  1 2 3
            ////  4 5 6
            ////  7 8 9
            //int[,] array = {
            //    { 1, 2, 3},
            //    { 4, 5, 6},
            //    { 7, 8, 9}
            //};

            ///*
            //int sumX = 0;
            //int sumY = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        sumX += array[i, j];
            //    }
            //    Console.WriteLine($"X축 {i + 1}번째 행 sum : {sumX}");
            //    sumX = 0;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        sumY += array[j, i];
            //    }
            //    Console.WriteLine($"Y축 {i + 1}번째 열 sum : {sumY}");
            //    sumY = 0;
            //}
            //*/

            //int[] sumX = new int[3];
            //int[] sumY = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        sumX[i] += array[i, j];
            //        sumY[j] += array[i, j];
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"X축 {i + 1}번째 행 sum : {sumX[i]}");
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Y축 {i + 1}번째 열 sum : {sumY[i]}");
            //}


            ////2차원배열인데
            ////행의 길이는 2, 열의 길이는 3인 2차원 배열에
            ////1부터 6까지의 숫자를
            ////행과 열을 구분해서 출력해봅시다.
            //// 123
            //// 456
            //int[,] array = {
            //    { 1, 2, 3},
            //    { 4, 5, 6},
            //};

            //for (int i = 0; i < array.GetLength(0); i++)
            //{ 
            //    for (int j = 0; j < array.GetLength(1); j++)
            //        Console.Write($"{array[i, j]} ");
            //    Console.WriteLine();
            //}

            // 3*3 빙고
            Board board = new Board();

            int x, y;
            bool isBingo = false;
            while (!isBingo)
            {
                Console.Clear();

                board.RenderBoard();

                Console.WriteLine("x, y 값을 입력해 주세요");
                Console.Write("x : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y : ");
                y = int.Parse(Console.ReadLine());

                board.InputNum(x, y);

                isBingo = board.CheckBingo();
                if (isBingo == true)
                {
                    Console.Clear();
                    board.RenderBoard();
                    Console.WriteLine("========================");
                    Console.WriteLine("성공!!");
                    break;
                }
            }
        }
    }
}
