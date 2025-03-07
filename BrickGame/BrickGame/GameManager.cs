using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class GameManager
    {
        Ball m_ball = null;
        Bar m_bar = null;

        public void Initialize()
        {
            if (m_ball == null)
            { 
                m_ball = new Ball();
                m_ball.Initialize();
            }
            if (m_bar == null)
            { 
                m_bar = new Bar();
                m_bar.Initialize();
            }
            //ball 에서 bar를 사용
            m_ball.SetBar(m_bar);
        }

        public void Progress()
        { 
            m_ball.Progress();
            m_bar.Progress(m_ball);
        }

        public void Render()
        { 
            Console.Clear();
            m_ball.Render();
            m_bar.Render();
        }
    }
}
