using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__枚举
{
    public enum Season
    {
        春,
        夏,
        秋,
        冬
    }
    public enum Gender
    {
        男,
        女
    }
    public enum QqState
    {
        在线 = 1,
        离线,
        隐身,
        离开,
        Q我吧
    }
    class Program
    {
        static void Main(string[] args)
        {
            //QqState state = QqState.夏;
            //Console.WriteLine(state);
            //Console.ReadKey();
            //Gender sex = Gender.男;
            //Console.WriteLine(sex);
            //Console.ReadKey();

           
                Console.WriteLine("请输入状态：1-在线，2-离线，3-隐身 ，4-离开，5-Q我吧");
            while (true)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        QqState s1 = (QqState)Enum.Parse(typeof(QqState), s);
                        Console.WriteLine(s1);
                        break;
                    case "2":
                        QqState s2 = (QqState)Enum.Parse(typeof(QqState), s);
                        Console.WriteLine(s2);
                        break;
                    case "3":
                        QqState s3 = (QqState)Enum.Parse(typeof(QqState), s);
                        Console.WriteLine(s3);
                        break;
                    case "4":
                        QqState s4 = (QqState)Enum.Parse(typeof(QqState), s);
                        Console.WriteLine(s4);
                        break;
                    case "5":
                        QqState s5 = (QqState)Enum.Parse(typeof(QqState), s);
                        Console.WriteLine(s5);
                        break;

                }
                Console.WriteLine("请输入状态：1-在线，2-离线，3-隐身 ，4-离开，5-Q我吧");
                Console.ReadKey();
            }

        }
    }
}
