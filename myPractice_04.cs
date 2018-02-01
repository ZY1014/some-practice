using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04判断
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("keyikan");
            }
            else if (age < 10)
            {
                Console.WriteLine("滚蛋");

            }
            else
            {
                Console.WriteLine("quedingma?yse/No");
                string resurt = Console.ReadLine();
                if (resurt == "yes")
                {
                    Console.WriteLine("haoba");
                }
                else
                    {
                    Console.WriteLine("你真棒");
                }
               
            }
            Console.ReadKey();
        }
    }
}
