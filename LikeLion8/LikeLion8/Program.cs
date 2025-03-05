using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            //foreach(var name in sortedNames)
            //    Console.WriteLine(name);

            //var firstName = names.First(n => n.StartsWith("A"));
            //Console.WriteLine($"First name starting with A: {firstName}");


            //int[] nums = { 5, 3, 8, 1 };

            ////메서드구문
            //var sortedMeshod = nums.OrderBy(n => n);

            ////쿼리구문
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;

            //Console.WriteLine("Meshod syntex:");
            //foreach (var n in sortedMeshod)
            //    Console.WriteLine(n);

            //Console.WriteLine("QUery syntex:");
            //foreach(var n in sortedQuery)
            //    Console.WriteLine(n);


            //Select()
            //Linq 쿼리 연산자 중 하나
            //각 요소를 변환하여 새로운 컬렉션을 생성
            //string[] words = { "apple", "banana", "cherry" };

            //var lengths = words.Select(w => w.Length);
            //foreach (var length in lengths)
            //    Console.WriteLine(length);

            //var upperWords = words.Select(w => w.ToUpper());
            //foreach (var word in upperWords)
            //    Console.WriteLine(word);


            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //foreach (var i in data)
            //    sum += i;
            //Console.WriteLine($"sum: {sum}");

            //int count = data.Length;
            //Console.WriteLine($"count: {count}");

            //double avg = data.Average();
            //Console.WriteLine($"average: {avg}");

            //int max = data.Max();
            //Console.WriteLine($"max: {max}");

            //int min = data.Min();
            //Console.WriteLine($"mina: {min}");

            ////근삿값
            //int[] data1 = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data1[0];

            //foreach (var d in data1)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}
            //Console.WriteLine($"nearest to {target}: {nearest}");

            ////Rank 알고리즘
            //int[] score = { 90, 70, 50, 70, 60 };

            //for (int i = 0; i < score.Length; i++)
            //{
            //    int rank = 1;
            //    for (int j = 0; j < score.Length; j++)
            //    {
            //        if (score[j] > score[i])
            //            rank++;
            //    }
            //    Console.WriteLine($"Score : {score[i]}, Rank: {rank}");
            //}

            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach (int i in data)
            //    Console.WriteLine(i);

            ////특정 값 검색하기: Search 알고리즘
            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index >= 0 ? $"Found at index{index}" : "Not found");

            //데이터를 특정 기준으로 그룹화하기
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            var groups = fruits.GroupBy(f => f[0]);
            foreach (var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");
                foreach (var f in group)
                    Console.WriteLine($" {f}"); ;
            }
        }
    }
}
