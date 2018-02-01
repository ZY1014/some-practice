using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length/2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length - i - 1];
                chs[chs.Length - 1 - i] = temp;
                
            }

            str = new string(chs);
            Console.Write(str);
            Console.ReadKey();
           
        }
    }
}
