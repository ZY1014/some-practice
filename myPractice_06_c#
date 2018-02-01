using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06switch__catch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //SWITCHCASE
            bool b = true;

            int salary = 5000;
            Console.WriteLine("请输入等级");
            string lever = Console.ReadLine();
            switch (lever)
            {
                case "A":
                    salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C": break;
                case "D":
                    salary -= 200;
                    break;
                default:
                    Console.WriteLine("请输入正确的等级");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("明年的工资是{0}", salary);
            }
            Console.ReadKey(); 
#endregion
        }
    }
}
