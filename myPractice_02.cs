using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Myseconddemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  秒时间转换
            //int seconds = 107653;
            //int day = seconds / 24 / 60 / 60;
            //int sesc = seconds % 86400;
            //int hours = sesc / 3600;
            //sesc = sesc % 3600;
            //int mins = sesc / 60;
            //sesc = sesc % 60;
            //Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, day, hours, mins, sesc);
            //Console.ReadKey();
            #endregion
            #region //不兼容类型转换
            //string num = "123";
            //double s =  Convert.ToDouble(num);
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(s);
            //Console.ReadKey();
            //Console.WriteLine(n);
            //Console.ReadKey();

            //Console.WriteLine("强输入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("语文成绩");
            //string strChines = Console.ReadLine();
            //Console.WriteLine("数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("英语成绩");
            //string strEnglish = Console.ReadLine();
            //int chines = Convert.ToInt32(strChines);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);
            //double sum = chines + math + english;
            //double avg = sum * 1.0 / 3;
            //Console.WriteLine("{0}的总成绩是{1},平均成绩是{2:0.00}", name, sum, avg);
            //Console.ReadKey();

            #endregion

            Console.WriteLine("输入语文成绩");
            double chines = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            bool a = chines > 90&& math>90;
            Console.WriteLine(a);
            Console.ReadKey();
            bool b = math > 90 || chines > 90;
            Console.WriteLine(b);
            Console.ReadKey();





        }
    }
}
