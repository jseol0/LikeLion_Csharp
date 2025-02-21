using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1
            Console.WriteLine("clone test"); // 변수에 저장된 값을 출력
            */

            /*2
            // 문자열
            string greeting;
            greeting = "Hello, World";

            // 변수의 값을 사용
            Console.WriteLine(greeting);
            */

            /*3
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
            */

            //4
            // 문자열
            string greeting;
            greeting = "Hello, World";

            // 변수의 값을 사용
            Console.WriteLine(greeting);

            //변수 선언과 초기화를 한번에 수행
            int score = 100;
            double temperature = 36.5;
            string city = "Seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city);

        }
    }
}
