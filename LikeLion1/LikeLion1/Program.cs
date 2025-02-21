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
            int globalVar = 10; // 전역 변수
            void DisplayVariables()
            {
                int localVar = 5; // 지역 변수
                Console.WriteLine($"Global: {globalVar}, Local: {localVar}");
            }
            DisplayVariables();
        }
    }
}
