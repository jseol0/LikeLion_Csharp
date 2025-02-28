using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;
        public BULLET[] playerBullet = new BULLET[MAXBULLET];
        public BULLET[] playerBullet2 = new BULLET[MAXBULLET];
        public BULLET[] playerBullet3 = new BULLET[MAXBULLET];
        public int Score = 0;
        public Item item = new Item();
        public int itemCount = 0;

        const int UPKEY = 72;
        const int DOWNKEY = 80;
        const int LEFTKEY = 75;
        const int RIGHTKEY = 77;
        const int SPACEBAR = 32;
        const int ESC = 27;
        const int MAXBULLET = 20;

        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < MAXBULLET; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }

        //키를 입력하는 부분
        public void GameMain()
        {
            KeyControl();
            PlayerDraw();

            UIscore();

            if (item.ItemLife)
            { 
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)   // 키가 눌렸을때 true
            { 
                pressKey = _getch();
                // 화살표 키 또는 특수 키 를 _getch()로 읽으면
                // 224, x 이렇게 두번 읽히기 때문에
                if (pressKey == 0 || pressKey == 224)
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case UPKEY:    // up
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case LEFTKEY:    // left
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case RIGHTKEY:    // right
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case DOWNKEY:    // down
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case SPACEBAR:    // spacebar
                        for (int i = 0; i < MAXBULLET; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                break;
                            }
                        }
                        for (int i = 0; i < MAXBULLET; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                break;
                            }
                        }
                        for (int i = 0; i < MAXBULLET; i++)
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                break;
                            }
                        }
                        break;
                    case ESC:
                        Environment.Exit(0);
                        break;

                }
            }
        }

        // 미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->";

            for (int i = 0; i < MAXBULLET; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.Write(bullet);

                    playerBullet[i].x++;    // 미사일 이동
                    if (playerBullet[i].x > 78) // 미사일이 끝까지 가면
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "->";

            for (int i = 0; i < MAXBULLET; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    Console.Write(bullet);

                    playerBullet2[i].x++;    // 미사일 이동
                    if (playerBullet2[i].x > 78) // 미사일이 끝까지 가면
                    {
                        playerBullet2[i].fire = false;
                    }
                }
            }
        }
        public void BulletDraw3()
        {
            string bullet = "->";

            for (int i = 0; i < MAXBULLET; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    Console.Write(bullet);

                    playerBullet3[i].x++;    // 미사일 이동
                    if (playerBullet3[i].x > 78) // 미사일이 끝까지 가면
                    {
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

        //플레이어 그리기
        public void PlayerDraw()
        {
            String[] player = new string[]
            { 
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < MAXBULLET; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if ((playerBullet[i].x >= enemy.enemyX - 1)
                            && (playerBullet[i].x <= enemy.enemyX + 1))
                        { 
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rnd = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rnd.Next(2, 22);

                            playerBullet[i].fire = false;

                            //스코어
                            Score += 100;
                        }
                    }
                }

                if (playerBullet2[i].fire == true)
                {
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if ((playerBullet2[i].x >= enemy.enemyX - 1)
                            && (playerBullet2[i].x <= enemy.enemyX + 1))
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rnd = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rnd.Next(2, 22);

                            playerBullet2[i].fire = false;

                            //스코어
                            Score += 100;
                        }
                    }
                }

                if (playerBullet3[i].fire == true)
                {
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if ((playerBullet3[i].x >= enemy.enemyX - 1)
                            && (playerBullet3[i].x <= enemy.enemyX + 1))
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rnd = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rnd.Next(2, 22);

                            playerBullet3[i].fire = false;

                            //스코어
                            Score += 100;
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                { 
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < MAXBULLET; i++)
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }
    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnemyMove()
        { 
            Random rnd = new Random();
            enemyX--;

            if (enemyX < 2)
            {
                enemyX = 77;
                enemyY = rnd.Next(2, 22);
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item";
            Console.Write(ItemSprite);
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //객체 생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            //프레임 속도
            int dwTime = Environment.TickCount;     // 1/1000 초가 흐른다

            while (true)
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                { 
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    

                    enemy.EnemyDraw();
                    enemy.EnemyMove();

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
