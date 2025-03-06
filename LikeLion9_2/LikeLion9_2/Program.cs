using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("간단한 RPG 게임을 시작합니다");

            //캐릭터 생성
            GameChaaracter warrior = new Warrior("전사");
            GameChaaracter mage = new Mage("마법사");

            //전투
            Console.WriteLine("======전투 시작======");

            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);
            Console.WriteLine();
            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("======전투 종료======");
        }
    }
}
