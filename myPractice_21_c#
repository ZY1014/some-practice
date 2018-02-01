using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_练习
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Zy\Desktop\1.txt";
            string[] str = File.ReadAllLines(path, Encoding.Default);

            for (int i = 0; i < str.Length; i++)
            {
                string[] newStr = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(newStr[0].Length > 10 ? newStr[0].Substring(0, 8) + "...   " + newStr[1] : newStr[0] + "  " + newStr[1]);
            }
            Console.ReadKey();

        }
    }
}
