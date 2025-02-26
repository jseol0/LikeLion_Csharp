using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4_함수
{
    internal class Program
    {
        //반환형 함수이름 (매개변수)
        static void Loading() {
            Console.WriteLine("로딩화면");
        }

        static void AttackFunction(int _Attack) {
            Console.WriteLine($"공격력 : {_Attack}");
        }

        static int BaseAttack() {
            int attack = 10;

            return attack;
        }

        static int Add(int a, int b) {
            return a + b;
        }

        static int StringLength(string s) { 
            return s.Length;
        }

        static int GetMaxValue(int a, int b, int c) {
            int ret = Math.Max(Math.Max(a, b), c);
            return ret;
        }


        static void Main(string[] args)
        {
            //Loading();

            //int Attack = 0;
            //int bAttack = 0;
            //Console.WriteLine("공격력을 입력하시오 : ");
            //Attack = int.Parse(Console.ReadLine());

            //bAttack = BaseAttack();

            //AttackFunction(Attack + bAttack);

            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 : {result}");

            //Q1. 배열 요소 출력
            int[] num1 = new int[5] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < 5; i++)
                Console.Write(num1[i] + " ");
            Console.WriteLine("\n");

            //Q2. 배열 요소 합 구하기
            int[] num2 = new int[5];
            int sum = 0;

            Console.WriteLine("숫자 입력 : ");
            for (int i = 0; i < 5; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());
                sum += num2[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //Q3. 최대값 찾기
            int[] num3 = new int[5] { 3, 8, 15, 6, 2 };

            int max = 0;
            for (int i = 0; i < num3.Length; i++)
            {
                if (max < num3[i])
                    max = num3[i];
            }
            Console.WriteLine(max);
            Console.WriteLine();

            //Q4. 1부터 10까지 출력 (for문)
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //Q5. 짝수만 출력 (while문)
            int j = 1;
            while (j <= 10)
            {
                if (j % 2 == 0)
                    Console.Write(j + " ");
                j++;
            }
            Console.WriteLine("\n");

            //Q6. 배열 요소 출력 (foreach 문)
            int[] num6 = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int num in num6)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //Q7. 두 수의 합을 구하는 함수
            Console.WriteLine($"3과 5의 합 : {Add(3, 5)}");
            Console.WriteLine("\n");

            //Q8. 문자열 길이 반환 함수
            Console.WriteLine("문자열을 입력해 주세요 : ");
            string s = Console.ReadLine();
            Console.WriteLine($"문자열 길이 : {StringLength(s)}");
            Console.WriteLine("\n");

            //Q9. 가장 큰 수 반환 함수
            Console.WriteLine($"가장 큰 수 : {GetMaxValue(1, 7, 4)}");
        }   
    }
}
