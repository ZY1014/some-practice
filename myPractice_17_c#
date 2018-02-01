using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_飞行棋
{
    class Program
    {   
        //静态字段模拟全局变量
        public static int[] Maps = new int[100];
        //静态数组存储玩家A、B坐标
        public static int[] PlayerPos = new int[2];
        //存储玩家姓名
        public static string[] PlayerNames = new string[2];
        //两个玩家标记
        public static bool[] Flags = new bool[2];

        static void Main(string[] args)
        {
            GameShow();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家A姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[1] == PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B姓名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B姓名不能和玩家A相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }

            }

            //输入姓名Ok后清屏
            Console.Clear();
           
            Console.WriteLine("{0}士兵用A表示", PlayerNames[0]);
            Console.WriteLine("{0}士兵用B表示", PlayerNames[1]);

            InitailMap();
            DrawMap();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}胜利",PlayerNames[0]);
                    break;
                }

                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {

                    Flags[0] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}胜利", PlayerNames[1]);
                    break;
                }

            }
            Console.WriteLine("游戏结束");
            Console.ReadKey();

        }

#region  //游戏头
        /// <summary>
        /// 游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Red;   
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White ;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******飞行棋 V1.0******");
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************");
        }
        #endregion

        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运转盘◎
            for (int i = 0; i < luckyturn.Length ; i++)
            {
                Maps[luckyturn[i]] = 1;
            }

            int[] landmine = {5,13,17,33,38,50,64,80,94 };//地雷☆
            for (int i = 0; i < landmine.Length; i++)
            {
                Maps[landmine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length ; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卍
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }

        }

        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘◎ 地雷:☆  暂停：▲  时空隧道：卍");
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine(); 
            }
            //第二横行
            for (int i = 64; i>=35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            //第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();

        }

        /// <summary>
        /// 画地图的方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap (int i)
        {
            string str = "";
            //如果玩家A、B坐标相同并且都在地图上，画一个<>
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                str = "<>";
            }
            else if (PlayerPos[0] == 1)
            {
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "卍";
                        break;
                }
            }
            return str;
        }

        public static void PlayGame(int playNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1,7);
            Console.WriteLine("{0}按任意键开始掷骰子",PlayerNames[playNumber] );
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playNumber],rNumber );
            PlayerPos[0] += rNumber;
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[ playNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playNumber]);
            Console.ReadKey(true);
            if (PlayerNames[playNumber] == PlayerNames[ playNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", PlayerNames[playNumber], PlayerNames[1 - playNumber], PlayerNames[playNumber]);
                PlayerPos[1 - playNumber] -= 6;
                Console.ReadKey(true);
            }
            else//踩到了关卡
            {
                switch (Maps[PlayerPos[playNumber]])
                {
                    case 0: Console.WriteLine("玩家{0}踩到了方块，安全", PlayerNames[playNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("玩家{0}踩到了幸运转盘，请选择1-交换位置 2-轰炸对方",PlayerNames[playNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择和玩家{1}交换位置，PlayerNames[playNumber],PlayerNames[1-playNumber]");
                                Console.ReadKey(true);
                                int temp = PlayerPos[playNumber];
                                PlayerPos[playNumber] = PlayerPos[1 - playNumber];
                                PlayerPos[1 - playNumber] = temp;
                                Console.WriteLine("交换完成，按任意键继续游戏！！！");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1},玩家{2}退6格", PlayerNames[playNumber], PlayerNames[1 - playNumber], PlayerNames[1 - playNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playNumber] -= 6;
                                Console.WriteLine("玩家{0}退了6格", PlayerPos[1 - playNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2 1--交换位置，2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playNumber], PlayerNames[1 - playNumber]);
                        Console.ReadKey(true);
                        PlayerPos[playNumber] -= 6;
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playNumber]);
                        Flags[playNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playNumber], PlayerNames[1 - playNumber]);
                        PlayerPos[playNumber] += 10;
                        Console.ReadKey(true);
                        break;
                }
            }
            ChangePos();
            Console.Clear();
            DrawMap();
        }
        /// <summary>
        /// 玩家坐标发生改变时
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }

            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }


        }


    }
}
