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
            Console.WriteLine("status");

            string name = "Alice";
            int hp = 100;
            double att = 56.7;
            char grade = 's';

            Console.WriteLine($"name : {name}");
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"att : {att}");
            Console.WriteLine($"grade : {grade}");
        }
    }
}
