using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            //    Console.WriteLine( "请输入一个数字");
            //    string s = Console.ReadLine();
            //    int Num = MustNum(s);
            //    Level(Num);
            //    Console.ReadKey();



            //}

            //public static int MustNum(string s)
            //{
            //    while(true)
            //    {
            //        try
            //        {
            //            int Num = Convert.ToInt32(s);
            //            return Num;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的不是数字请重新输入");
            //            s = Console.ReadLine();
            //        }
            //    }



            //}

            //public static void Level(int Num)
            //{
            //    while (true) {
            //        if (90 < Num && Num <= 100)
            //        {
            //            Console.WriteLine("优");
            //            return;
            //        }
            //        else if (80 < Num && Num <= 90)
            //        {
            //            Console.WriteLine("良");
            //            return;
            //        }
            //        else if (60 < Num && Num <= 80)
            //        {
            //            Console.WriteLine("中");
            //            return;
            //        }
            //        else if (0 < Num && Num <= 60)
            //        {
            //            Console.WriteLine("差");
            //            return;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入不正确，请输入0-100间的数字");
            //            string s = Console.ReadLine();
            //            Num = MustNum(s);
            //        }
            //    }

            //         string[] Entry = {"中国","美国","巴西","澳大利亚","加拿大"};
            //         Change(Entry);
            //        // Console.WriteLine(s);
            //        // Console.ReadKey();



            //     }

            //     public static void  Change(string[] s)
            //{
            //         for (int i = 0; i < s.Length/2 ; i++)
            //         {
            //             string name1 =s[i];
            //             s[i] = s[s.Length - i - 1];
            //             s[s.Length - i - 1] = name1;
            //         }
            //         for (int i = 0; i < s.Length; i++)
            //         {
            //             Console.WriteLine(s[i]);
            //         }
            //         Console.ReadKey();
            #endregion
            Console.WriteLine("请输入半径");
            string r = Console.ReadLine();
            double j = MustNum(r);
            double s = Math(j);
            Console.WriteLine(s);
            Console.ReadKey();

        }


        public static double Math(double i)
        {
            double s = 3.14 * i * i;
            double c = 2 * 3.14 * i;
            return s;

        }



        public static double MustNum(string s)
        {
            while (true)
            {
                try
                {
                    double Num = Convert.ToDouble(s);
                    return Num;
                }
                catch
                {
                    Console.WriteLine("输入的不是数字请重新输入");
                    s = Console.ReadLine();
                }
            }

        }

    }    }
