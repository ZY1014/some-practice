using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_练习
{
     public class Program
    {
        public static void Main(string[] args)
        {
            //string s = "abcdefg";
            //char[] chs = s.ToCharArray();
            //chs[0] = 'b';
            //s = new string(chs);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //Console.WriteLine("diyieg");
            //string a = Console.ReadLine();
            //Console.WriteLine( "dierge");
            //string b = Console.ReadLine();
            ////不区分大小写
            //if (a.Equals(b,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("same");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            //Console.ReadKey();

            //string s = "a b  c dfg + - ++ = f";
            ////分割字符串split

            //char[] chs = { ' ', '+', '-', '=' };
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}{1}{2}{3}{4}",str[0],str[1],str[2],str[3],str[4] );

            //Console.ReadKey();


            //string s = "2008-08-08";
            ////char[] chs = { '-' };
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0},{1},{2}", date[0], date[1], date[2]);
            //Console.ReadKey();


            //string str = "              haha ah ha         ";
            //str = str.Trim();
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "哈哈关键字替换";
            //if (str.Contains("哈哈"))
            //{
            //    str = str.Replace("哈哈", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "今天天气好晴朗";
            //str = str.Substring(1, 3);
            //Console.WriteLine(str);
            //Console.ReadKey(); 

            string str = "今天aa天气好天晴朗";

            //bool b = str.StartsWith("天");
            //Console.WriteLine(b);
            //Console.ReadKey();

            //int I = str.LastIndexOf('天',);
            //Console.WriteLine(I);
            //Console.ReadKey();

            //string path = @"c\z\dsa\d\v\s\df\sf\qw\das\找到我";
            //int i = path.LastIndexOf("\\");
            //path = path.Substring(i + 1);
            //Console.WriteLine(path);
            //Console.ReadKey();

            //string str1 = "hah ";
            //bool b = string.IsNullOrEmpty(str1);
            //Console.WriteLine(b);
            //Console.ReadKey();

            string[] names = { "张三", "李四", "王五" };
            string str2 = string.Join("|", names);
            Console.WriteLine(str2);
            Console.ReadKey();





        }
      
    }
}
