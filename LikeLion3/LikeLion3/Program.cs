using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터
            //hp : 100
            //att : 56.7
            //캐릭터이름 : ??
            //등급 : s;
            
            string name = "Alice";
            int hp = 100;
            double att = 56.7;
            char grade = 's';

            // 1. 문자열 보간법
            // 연산이 더 빠르고 효율적
            Console.WriteLine("status");

            Console.WriteLine($"name : {name}");
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"att : {att}");
            Console.WriteLine($"grade : {grade}");

            Console.Write("\n\n\n");

            // 2. + 연산자
            // + 연산자는 문자열을 계속 새로운 문자열로 할당하기 때문에, 성능이 조금 떨어짐
            Console.WriteLine("status");

            Console.WriteLine("name : " + name);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);
            Console.WriteLine("grade : " + grade);
        }
    }
}
