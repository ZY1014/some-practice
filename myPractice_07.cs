using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum = sum + i;
            //    i++;
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //int sum = 0;
            //double avg = 0;
            //int i = 1;
            //int score = 0;
            //Console.WriteLine("请输入班级人数");
            //int peoples = Convert.ToInt32(Console.ReadLine());
            //while (i <= peoples)
            //{
            //    Console.WriteLine("请输入第{0}名同学的成绩", i);
            //    score = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + score;
            //    avg = sum / i;
            //    i++;

            //}
            //Console.WriteLine("共{0}名同学，总分{1},平均分{2}", i, sum, avg);
            //Console.ReadKey();

            //int years = 2006;
            //double num = 80000;
            //while (num < 200000)
            //{
            //    num = num * 1.25;
            //    years++;
            //}
            //Console.WriteLine("这一年{0}", years);
            //Console.ReadKey();

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("这道题会做了吗？ Y/N");
            //    string resurt = Console.ReadLine();
            //    if (resurt == "Y")
            //        break;
            //    else
            //    i++;
            //}
            //Console.WriteLine("放学了");
            //Console.ReadKey();
            //string input;
            //Console.WriteLine("请输入一个数字");
            //input = Console.ReadLine();
            //while (input != "Q")
            //{
            //    Console.WriteLine(Convert.ToInt32(input)*2);
            //    Console.WriteLine("请输入一个数字");
            //    input = Console.ReadLine();
            //}

            //Console.ReadKey();





            //Console.WriteLine("请输入一个正整数");
            //int max = 0;
            //string num = Console.ReadLine();
            //while (num != "end") 
            //{
            //    try
            //    {
            //        if (max < Convert.ToInt32(num))

            //        {
            //            max = Convert.ToInt32(num);
            //            Console.WriteLine("请输入一个正整数");
            //            num = Console.ReadLine();

            //        }

            //        else
            //        {
            //            Console.WriteLine("最大的正整数是{0}", max);
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("您输入的数字不正确，退出");
            //        break;
            //   }

            //}
            //Console.ReadKey();

            //string input = "";
            //int max = 0;
            //while (input != "end")
            //{
            //    Console.WriteLine("请输入数字我们将显示最大值");
            //    input = Console.ReadLine();
            //    if (input != "end")
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(input);
            //            if (max < num)
            //            {
            //                max = num;
            //            }
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的不是数字，重新输入");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入的最大值是{0}",max);
            //    }

            //}


            //Console.ReadKey();

            //100-999之间的水仙花数
            //int  s, j,k;

            //for (int i = 100; i <= 999; i++)
            //{
            //    s = i / 100;
            //    j = i % 100 / 10;
            //    k = i % 10;
            //    if (i == s * s * s + j * j * j + k * k * k)
            //    {9
            //        Console.WriteLine("{0}",i);
            //    }
            //}
            //Console.ReadKey();

            //for (int i = 1; i <=9 ; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //Console.WriteLine("请输入一个数值");
            //int j = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= j; i++)
            //{


            //    for (int s = j; s == 0 ; s--)
            //    {
            //        Console.WriteLine( "{0}+{1}={2}",i,s,i+s);
            //    }
            //for (int s = j; s == 0; s--)
            //{
            //    Console.WriteLine("{0}+{1}={2}",i,s,i+s);
            //}

            //    Console.WriteLine();
            //}

            //Console.ReadKey();
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}人的年龄",i+1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入年龄不正确，程序退出");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch {
            //        Console.WriteLine("输入的年龄格式不正确，程序退出");
            //        b = false;
            //        break;
            //    }
            //}
            //if (b == true)
            //{
            //    Console.WriteLine("五个人的平均年龄是{0}",sum/5);
            //}

            //Console.ReadKey();

            //string name = "";
            //string psw = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    psw = Console.ReadLine();
            //    if (name == "admin" && psw == "888888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码不正确，请重新输入");
            //    }
            //}
            //Console.ReadKey();



            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum >= 20)
            //    {
            //        Console.WriteLine("{0}",i);
            //        break;
            //    }

            //}
            //Console.ReadKey();


            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {

            //        i++;
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i;
            //        i++;
            //    }


            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //for (int i = 2; i <= 100; i++)
            //{
            //    bool b = true;
            //    for (int j =2; j <(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;

            //        }
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            string resurt = name=="a" ? "c" : "d";
            Console.WriteLine(resurt);
            Console.ReadKey();
        }
    }
}
