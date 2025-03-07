using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_practice
{
    public class Player
    {
        public Info m_info;

        public Info GetInfo() { return m_info; }
        public void SetInfo(Info info) { m_info = info; }
        public void SetHp(int hp) { m_info.Hp = hp; }
        public void SetDamage(int attack) { m_info.Hp -= attack; }   // 내 체력 - 상대방의 공격력

        public void SelectJob()
        {
            m_info = new Info();
            int input = 0;

            Console.WriteLine("직업을 선택하시오 1.전사 2.마법사 3.도적 : ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    m_info.Name = "전사";
                    m_info.Hp = 100;
                    m_info.Attack = 10;
                    break;
                case 2:
                    m_info.Name = "마법사";
                    m_info.Hp = 80;
                    m_info.Attack = 20;
                    break;
                case 3:
                    m_info.Name = "도적";
                    m_info.Hp = 90;
                    m_info.Attack = 15;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"직업 : {m_info.Name}\t체력 : {m_info.Hp}\t공격력 : {m_info.Attack}");
        }
    }
}
