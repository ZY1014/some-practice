using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int mounths = 0;
            //int year = 0;
            //bool b = false;

            //Console.WriteLine("请输入年份");
            //try
            //{
            //     year = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的年份");
            //}
            //bool a = (year % 400 == 0) || (year % 4==0 && year % 100 != 0);
            //if (a == true)
            //{
            //    Console.WriteLine("请输入月份");
            //    try
            //    {
            //        mounths = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确的月份");
            //    }
            //    if (1 <= mounths && mounths <= 12)
            //        b = true;
            //    if (b)
            //    {
            //        switch (mounths)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 9:
            //            case 12:
            //                Console.WriteLine("该月31天");
            //                break;
            //            case 2:
            //                Console.WriteLine("该月29天");
            //                break;
            //            case 4:
            //            case 6:
            //            case 8:
            //            case 10:
            //            case 11:
            //                Console.WriteLine("该月30天");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入正确的月份");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("请输入月份");
            //    b = 1 <= mounths && mounths <= 12;
            //    try
            //    {
            //        mounths = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确的月份");
            //    }
            //    if (1 <= mounths && mounths <= 12)
            //        b = true;
            //    if (b)
            //    {
            //        switch (mounths)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 9:
            //            case 12:
            //                Console.WriteLine("该月31天");
            //                break;
            //            case 2:
            //                Console.WriteLine("该月28天");
            //                break;
            //            case 4:
            //            case 6:
            //            case 8:
            //            case 10:
            //            case 11:
            //                Console.WriteLine("该月30天");
            //                break;
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("请输入正确的月份");
            //    }

            //} 
            //Console.ReadKey();
            #endregion
            Console.WriteLine("请输入年份");
            int days = 0;
            try
            {
                int years = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int mounths = Convert.ToInt32(Console.ReadLine());
                    if (mounths >= 1 && mounths <= 12)
                    {
                        switch (mounths)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                days = 31;
                                break;
                            case 2:
                                if ((years % 400 == 0) || (years % 4 == 0 && years % 100 != 0))
                                {
                                    days = 29;
                                }
                                else
                                {
                                    days = 28;
                                }
                                break;
                            default:
                                days = 30;
                                break;
                        }//switch case 括号
                        Console.WriteLine("{0}年，第{1}月，有{2}天",years,mounths,days);
                    }
                    else
                    {
                        Console.WriteLine("月份不符合规范，退出");
                    }
                }//try月份括号
                catch {
                    Console.WriteLine("请输入正确的月份");
                }
            }//try年份括号
            catch
            {
                Console.WriteLine("年份格式不正确");
            }
            
            Console.ReadKey();

        }
    }
}
