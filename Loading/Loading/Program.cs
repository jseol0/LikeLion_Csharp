using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("□□□□□□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■□□□□□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■□□□□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■□□□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■□□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■□□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■■□□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■■■□□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■■■■□□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■■■■■□");
            //Thread.Sleep(3000); // 2000ms
            //Console.Clear();
            //Console.WriteLine("■■■■■■■■■■");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(new string('■', i) + new string('□', 10 - i));
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.Write("Press Enter");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("당신은 늦은 새벽 편의점에 가기 위해 횡단보도를 건너고 있다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\"빠앙~\" 갑자기 들려오는 소리와 함께 밝은 빛이 눈을 가린다");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("이세계로 떠나시겠습니까?");
            Console.WriteLine("y / n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Console.WriteLine("-THE END-");
            }
            else {
                Console.Clear();
                Console.WriteLine("-THE END-");
            }
            
        }
    }
}
