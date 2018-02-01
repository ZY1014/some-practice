using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11方法2
{
    class Program
    {
        static void Main(string[] args)
        {



            //{ int b = 5;
            //    int a = Resurt(b);
            //    Console.WriteLine(a);
            //    Console.ReadKey();
            //}
            ///// <summary>
            ///// 输入一个数，返回数值加5
            ///// </summary>
            ///// <param name="a">输入一个整数</param>
            ///// <returns>返回数值加五</returns>
            //public static int Resurt(int a)
            //{
            //    a += 5;
            //    return a;

            //bool b =  IsRun(2000);
            // Console.WriteLine(b);
            // Console.ReadKey();
            while (true)
            {
                Console.WriteLine("请输入一个数值");
                string a = Console.ReadLine();
                bool c = int.TryParse(a, out int b);
                if (c)
                {
                    Console.WriteLine(b);
                    break;
                }
                else
                {
                    Return();
                    Console.ReadKey();
                }
            }


            
        }

        public static void Return()
        {
            Console.WriteLine("请重新输入");//尽量放在main方法里
            Console.ReadKey();
        }

        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>是否是闰年</returns>
            //public static bool IsRun(int year)
            //{
            //    bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            //    return b;
            //}
        
         
    }
}
