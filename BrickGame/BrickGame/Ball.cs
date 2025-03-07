using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Ball
    {
        BallData m_ballDate = new BallData();
        Bar m_bar;

        //C#공의 방향 배열 정의 [충돌한 벽, 들어온 방향]
        int[,] m_wallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1,  4 },
            { -1, -1, -1, -1,  2,  1 },
            { -1,  5,  4, -1, -1, -1 },
            { -1, -1,  1,  0,  5, -1 }
        };

        public BallData GetBall() { return m_ballDate; }
        public void SetX(int x) { m_ballDate.nX += x; }
        public void SetY(int y) { m_ballDate.nY += y; }
        public void SetBall(BallData ballData) { m_ballDate = ballData; }
        public void SetReady(int ready) { m_ballDate.nReady = ready; }
        public void SetBar(Bar bar) { m_bar = bar; }
        public int Collisoion(int x, int y)
        {
            //벽충돌
            if (y == 0) // 위
            {
                m_ballDate.nDirect = m_wallCollision[0, m_ballDate.nDirect];
                return 1;
            }
            if (x == 1) // 왼쪽
            {
                m_ballDate.nDirect = m_wallCollision[1, m_ballDate.nDirect];
                return 1;
            }
            if (x == 77) // 오른쪽
            {
                m_ballDate.nDirect = m_wallCollision[2, m_ballDate.nDirect];
                return 1;
            }
            if (y == 23) //아래
            {
                m_ballDate.nDirect = m_wallCollision[3, m_ballDate.nDirect];
                return 1;
            }

            //Bar충돌처리
            if (x >= m_bar.m_barData.nX[0] && x <= m_bar.m_barData.nX[2] + 1 &&
                y == (m_bar.m_barData.nY)) //바 위 충돌
            {
                if (m_ballDate.nDirect == 1)
                    m_ballDate.nDirect = 2;
                else if (m_ballDate.nDirect == 2)
                    m_ballDate.nDirect = 1;
                else if (m_ballDate.nDirect == 5)
                    m_ballDate.nDirect = 4;
                else if (m_ballDate.nDirect == 4)
                    m_ballDate.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_bar.m_barData.nX[0] && x <= m_bar.m_barData.nX[2] + 1 &&
              y == (m_bar.m_barData.nY + 1)) //바 아래 충돌
            {
                if (m_ballDate.nDirect == 1)
                    m_ballDate.nDirect = 2;
                else if (m_ballDate.nDirect == 2)
                    m_ballDate.nDirect = 1;
                else if (m_ballDate.nDirect == 5)
                    m_ballDate.nDirect = 4;
                else if (m_ballDate.nDirect == 4)
                    m_ballDate.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            return 0;
        }

        public void Initialize()
        {
            m_ballDate.nReady = 0;  // 안움직일때 1 움직일때 0
            m_ballDate.nDirect = 1;
            m_ballDate.nX = 30;
            m_ballDate.nY = 10;

            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if (m_ballDate.nReady == 0)
            {
                //공의 방향에 따른 스위치문
                switch (m_ballDate.nDirect)
                { 
                    case 0: // 위
                        if (Collisoion(m_ballDate.nX, m_ballDate.nY - 1) == 0)
                            m_ballDate.nY--;
                        break;
                    case 1: // 오른쪽 위
                        if (Collisoion(m_ballDate.nX + 1, m_ballDate.nY - 1) == 0)
                        {
                            m_ballDate.nX++;
                            m_ballDate.nY--;
                        }
                        break;
                    case 2: // 오른쪽 아래
                        if (Collisoion(m_ballDate.nX + 1, m_ballDate.nY + 1) == 0)
                        {
                            m_ballDate.nX++;
                            m_ballDate.nY++;
                        }
                        break;
                    case 3: // 아래
                        if (Collisoion(m_ballDate.nX, m_ballDate.nY + 1) == 0)
                            m_ballDate.nY++;
                        break;
                    case 4: // 왼쪽 아래
                        if (Collisoion(m_ballDate.nX - 1, m_ballDate.nY + 1) == 0)
                        {
                            m_ballDate.nX--;
                            m_ballDate.nY++;
                        }
                        break;
                    case 5: // 왼쪽 위
                        if (Collisoion(m_ballDate.nX - 1, m_ballDate.nY - 1) == 0)
                        {
                            m_ballDate.nX--;
                            m_ballDate.nY--;
                        }
                        break;
                }
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(m_ballDate.nX, m_ballDate.nY);
            Console.Write("●");
        }

        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 1; i < 23; i++)
            {
                Program.gotoxy(0, i);
                Console.Write("┃                                                                              ┃");
            }
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
