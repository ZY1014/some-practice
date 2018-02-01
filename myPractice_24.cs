using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24多媒体复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"G:\云盘下载.avi";
            string target = @"C:\Users\Zy\Desktop\new.avi";
            copyFile(source,target);
            Console.WriteLine("ok");
            Console.ReadKey();
        }

        public static void copyFile(string source, string target)
        {
            using (FileStream fileRead = new FileStream(source,FileMode.Open, FileAccess.Read))

            {

                using (FileStream fileWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                  
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        int r = fileRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }

                        fileWrite.Write(buffer, 0, r);

                    }
                }

            }
        }

 
    }
}
