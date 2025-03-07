using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_practice
{
    public class MainGame
    {
        public Player m_player = null;
        public Field m_field = null;

        public void Initialize()
        { 
            m_player = new Player();
            m_player.SelectJob();
        }

        public void Progress()
        { 
            int input = 0;

            while (true)
            {
                Console.Clear();
                m_player.Render();
                
                Console.WriteLine("1.사냥터 2.종료 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    // 사냥터
                    if (m_field == null)
                    {
                        m_field = new Field();
                        //필드에 플레이어 생성
                        m_field.SetPlayer(m_player);
                    }
                    //전투
                    m_field.Progress();
                }
                else if (input == 2)
                {
                     break;
                }

            }
        }

    }
}
