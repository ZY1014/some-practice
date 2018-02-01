using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool b = true;
            Console.WriteLine("请输入数字");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("请输入数值");
                b = false;
            }
            if (b)
            {
                Console.WriteLine(num * 2);
            }
            Console.ReadKey();

        }
    }
}
