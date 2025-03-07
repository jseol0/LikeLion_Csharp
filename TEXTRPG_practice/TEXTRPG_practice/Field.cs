using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_practice
{
    public class Field
    {
        public Player m_plyer = null;
        public Monster m_monster = null;

        public void SetPlayer(Player pplyer) { m_plyer = pplyer; }

        public void CreateMonster(int input)
        {
            m_monster = new Monster();
            Info info = new Info();

            switch (input)
            {
                case 1:
                    info.Name = "초급몹";
                    info.Hp = 30;
                    info.Attack = 3;
                    m_monster.SetInfo(info);
                    break;
                case 2:
                    info.Name = "중급몹";
                    info.Hp = 60;
                    info.Attack = 6;
                    m_monster.SetInfo(info);
                    break;
                case 3:
                    info.Name = "고급몹";
                    info.Hp = 60;
                    info.Attack = 6;
                    m_monster.SetInfo(info);
                    break;
            }
        }

        public void Fight()
        { 
            int input = 0;

            while (true)
            { 
                Console.Clear();
                m_plyer.Render();
                m_monster.Render();

                Console.WriteLine("행동을 고르시오: ");
                Console.WriteLine("1.공격 2.도망");

                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    m_plyer.SetDamage(m_monster.GetInfo().Attack);
                    m_monster.SetDamage(m_plyer.GetInfo().Attack);

                    if (m_plyer.GetInfo().Hp <= 0)
                    {
                        m_plyer.SetHp(100);
                        break;
                    }
                }
                if (input == 2 || m_monster.GetInfo().Hp <= 0)
                {
                    //새로운 몬스터를 생성하기 위해 null처리
                    m_monster = null;
                    break;
                }
            }
        }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();

                m_plyer.Render();
                Console.WriteLine("난이도를 고르시오: ");
                Console.WriteLine("1.초급 2.중급 3.고급 4.전단계");
                
                input = int.Parse(Console.ReadLine());
                if (input > 0 && input < 4)
                {
                    CreateMonster(input);
                    Fight();
                }
                else if (input == 4)
                { 
                    break;
                }
            }
        }
    }
}
