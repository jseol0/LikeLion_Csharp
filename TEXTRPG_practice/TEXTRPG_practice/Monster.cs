using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_practice
{
    public class Monster
    {
        public Info m_info;

        public Info GetInfo() { return m_info; }
        public void SetInfo(Info info) { m_info = info; }
        public void SetDamage(int attack) { m_info.Hp -= attack; }   // 내 체력 - 상대방의 공격력

        public void Render()
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"난이도 : {m_info.Name}\t체력 : {m_info.Hp}\t공격력 : {m_info.Attack}");
        }
    }
}
