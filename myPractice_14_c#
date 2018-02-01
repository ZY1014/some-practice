using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_out
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("请输入用户名");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string UserPsw = Console.ReadLine();
            //    string mag;
            //    bool b = IsLogin(userName, UserPsw, out mag);
            //    Console.WriteLine("登陆结果{0}",b );
            //    Console.WriteLine("登陆信息{0}",mag);
            //    Console.ReadKey();


            //}
            ///// <summary>
            /////返回是否登陆成功 如果不成功告知错误信息
            ///// </summary>
            ///// <param name="name">用户户名</param>
            ///// <param name="psw">密码</param>
            ///// <param name="msg">多余的登陆信息</param>
            ///// <returns>登陆结果</returns>
            //public static bool IsLogin(string name ,string psw, out string msg)
            //{
            //    if (name == "admin" && psw == "888888")
            //    {
            //        msg = "登陆成功";
            //        return true;
            //    }
            //    else if (name == "admin")
            //    {
            //        msg = "密码错误";
            //        return false;
            //    }
            //    else if (psw == "888888")
            //    {
            //        msg = "用户名错误";
            //        return false;
            //    }
            //    else
            //    {
            //        msg = "未知错误";
            //        return false;
            //    }


            Console.WriteLine("请输入一个数");
            string a = Console.ReadLine();
            int num;
            bool b = MyTryParse(a,out num);
            Console.WriteLine("转换{0},{1}",b,num);
            Console.ReadKey();
                




        }

        public static bool MyTryParse(string s, out int num)
        {

            num = 0;
            try
            {
                num = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }


        }


    }
}
