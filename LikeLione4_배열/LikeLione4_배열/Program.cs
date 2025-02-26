using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _LikeLione4_배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 배열
            //// 1. 컬렉션 - 데이터를 저장하는 자료구조
            //// 배열은 가장 기본적인 컬렉션 형태
            //// 2. 배열 - 동일한 데이터 타입의 연속된 집합
            //Console.WriteLine("=== 기본 배열 ===");
            //string[] fruits = { "사과", "바나나", "오렌지" };

            //// 3. 배열 선언하기 - 다양한 방법
            //Console.WriteLine("\n=== 배열 선언 방법 ===");
            //int[] numbers1 = new int[3]; // 크기만 지정
            //int[] numbers2 = new int[] { 1, 2, 3 };// 초기화와 함께 선언
            //int[] numbers3 = { 1, 2, 3 }; // 간단한 선언과 초기화

            //// 4. 1차원 배열 사용
            //Console.WriteLine("\n=== 1차원 배열 사용 ===");
            //int[] scores = new int[3];
            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //// 배열 순회하기
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}: {scores[i]}");
            //}

            //// 5. 다차원 배열
            //Console.WriteLine("\n=== 다차원 배열 ===");

            //// 2차원 배열 선언
            //int[,] matrix = new int[2, 3] {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //// 2차원 배열 순회
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //// 6. 가변 배열 (Jagged Array)
            //Console.WriteLine("\n=== 가변 배열 ===");
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //// 가변 배열 순회
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //// 7. var 키워드로 배열 선언하기
            //Console.WriteLine("\n=== var 키워드 사용 ===");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");

            //int[] num = new int[3];

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            //Console.WriteLine(num[2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[3] { 1, 2, 3 };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            ////3명의 국어, 영어, 수학 점수를 입력받고 총점과 평균을 출력하세요
            //int[] iKor = new int[3];
            //int[] iEng = new int[3];
            //int[] iMath = new int[3];

            //int[] sum = new int[3];
            //float[] aver = new float[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("성적을 입력하시오");
            //    Console.Write("국어 : ");
            //    iKor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    iEng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    iMath[i] = int.Parse(Console.ReadLine());

            //    sum[i] = iKor[i] + iEng[i] + iMath[i];
            //    aver[i] = (float)sum[i] / 3;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1}번학생");
            //    Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]}");
            //    Console.WriteLine($"총점 : {sum[i]}");
            //    Console.WriteLine($"평균 : {aver[i]:F2}");
            //}

            ////1차원 배열
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for (int i = 0; i < scores.Length; i++) {
            //    Console.WriteLine($"점수 {i + 1} : {scores[i]}");
            //}

            //double value = 123.456789;
            ////소수점 자릿수 설정하는 포맷
            //Console.WriteLine($"{value:F2}");
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine(String.Format("{0:F2}", value));

            ////소수점 버리고 정수만 출력
            //Console.WriteLine(value.ToString("F0"));

            ////천자리 마다 쉼표
            //double value2 = 12341234.12323;
            //Console.WriteLine(value2.ToString("N2"));


            ////2차원 배열 선언
            //int[,] matrix = new int[2, 3] {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //for (int i = 0; i < 2; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //// 가변배열
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2};
            //jaggedArray[1] = new int[] { 3, 4, 5};
            //jaggedArray[2] = new int[] { 6 };

            ////출력
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //// 빙고 만들기

            //int[] iArray = new int[25];

            //for (int i = 0; i < 25; i++) {
            //    iArray[i] = i + 1;
            //}

            //// 셔플
            //Random rnd = new Random();
            //for (int i = 0; i < 100; i++) { 
            //    int iA = rnd.Next(0, 25);
            //    int iB = rnd.Next(0, 25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;
            //int iBingo = 0;
            //int iCount = 0;

            //// 빙고판
            //while (true) {
            //    Console.Clear();

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write($"{iArray[i * 5 + j]:D2} ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine($"빙고 숫자 : {iBingo}");
            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;

            //    for (int i = 0; i < 25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }

            //    //빙고 체크 로직
            //    //가로 체크
            //    for (int i = 0; i < 5; i++) {
            //        for (int j = 0; j < 5; j++) {
            //            if (iArray[i * 5 + j] == 0) { 
            //                iCount++;
            //            }

            //            if (iCount == 5) {
            //                iBingo++;
            //            }
            //        }
            //        iCount = 0;
            //    }
            //    //세로 체크
            //    for (int i = 0; i < 5; i++) {
            //        for (int j = 0; j < 5; j++) {
            //            if (iArray[i + 5 * j] == 0) {
            //                iCount++;
            //            }

            //            if (iCount == 5) {
            //                iBingo++;
            //            }
            //        }
            //        iCount = 0;
            //    }
            //    //대각선
            //    for (int i = 0; i < 5; i++) {
            //        if (iArray[i * 4] == 0) {
            //            iCount++;
            //        }

            //        if (iCount == 5)
            //            iBingo++;
            //    }
            //    iCount = 0;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            iCount++;
            //        }

            //        if (iCount == 5)
            //            iBingo++;
            //    }
            //    iCount = 0;

            //    if (iBingo >= 5) {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }
            //}


            //2차원 배열
            int[,] board = new int[5, 5];
            bool[,] marked = new bool[5, 5];

            int bingoCount = 0;
            Random rnd = new Random();

            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            for (int i = 0; i < 100; i++) { 
                int a = rnd.Next(0, 25);
                int b = rnd.Next(0, 25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 swap 하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            int index = 0;
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    board[i, j] = numbers[index++];
                }
            }

            while (bingoCount < 5) {
                Console.Clear();

                Console.WriteLine("현재 빙고판");
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j], 2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.WriteLine("숫자를 입력하세요 (1 ~ 25) :");

                int input = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        if (board[i, j] == input) { 
                            marked[i, j] = true;
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                bingoCount = 0;
                
                for (int i = 0; i < 5; i++) {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++) {
                        if (!marked[i, j])
                            rowBingo = false;
                    }

                    if (rowBingo)
                        bingoCount++;
                }

                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;
                    for (int i = 0; i < 5; i++)
                    {
                        if (!marked[i, j])
                            colBingo = false;
                    }

                    if (colBingo)
                        bingoCount++;
                }

                bool diag1Bingo = true;
                for (int i = 0; i < 5; i++) { 
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;

                bool diag2Bingo = true;
                for (int i = 0; i < 5; i++) { 
                    if (!marked[i, 4 - i])
                        diag2Bingo = false;
                }
                if (diag2Bingo)
                    bingoCount++;
            }

            Console.WriteLine("빙고 5개 완성!");
        }
    }
}
