using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Bar
    {
        public BarData m_barData = new BarData();
        int m_catch; //공을 잡았는지 체크

        const int LEFTKEY = 75; // 상수로 만들어준다.  변수에 값 대입 x
        const int RIGHTKEY = 77;

        public void Initialize()
        {
            m_catch = 0;

            m_barData.nY = 18;
            m_barData.nX[0] = 12;
            m_barData.nX[1] = 14;
            m_barData.nX[2] = 16;

        }

        //공의 객체를 가지고와서 잡았는지 판단및 움직임도 줘야함 ref 로 인자값 전달 참조 
        public void Progress(Ball pBall)
        {
            int nKey = 0;

            if (Console.KeyAvailable)
            {
                nKey = Program._getch(); //키눌림 값

                switch (nKey)
                {
                    case LEFTKEY: //왼쪽 
                        if (m_barData.nX[0] > 1)
                        {
                            m_barData.nX[0]--;
                            m_barData.nX[1]--;
                            m_barData.nX[2]--;
                        }
                        if (pBall.GetBall().nReady == 1 && m_catch == 1)
                        {
                            //공이 잡힌상태
                            pBall.SetX(-1); //공왼쪽으로 움직이게 값주기
                        }

                        break;
                    case RIGHTKEY:
                        if (m_barData.nX[2] + 1 < 79)
                        {
                            m_barData.nX[0]++;
                            m_barData.nX[1]++;
                            m_barData.nX[2]++;
                        }
                        if (pBall.GetBall().nReady == 1 && m_catch == 1)
                        {
                            //공이 잡힌상태
                            pBall.SetX(1);//공오른쪽으로 움직이게 값주기
                        }
                        break;
                    case 'a':
                        pBall.SetReady(0); //공이움직임 
                        m_catch = 0;
                        break;
                    case 's':
                        if (pBall.GetBall().nX >= m_barData.nX[0] &&
                            pBall.GetBall().nX <= m_barData.nX[2] + 1 &&
                            pBall.GetBall().nY == (m_barData.nY - 1))
                        {
                            pBall.SetReady(1);
                            m_catch = 1;
                        }
                        break;
                }
            }
        }

        public void Render()
        {
            for (int i = 0; i < 3; i++)
            {
                Program.gotoxy(m_barData.nX[i], m_barData.nY);
                Console.Write("▥");
            }
        }
    }
}
