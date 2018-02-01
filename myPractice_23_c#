using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = {1,2,3,4,5,6,7,8,9};

            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < number.Length ; i++)
            //{
            //    if (number[i] % 2 == 0)
            //    {
            //        listOu.Add(number[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(number[i]);
            //    }

            //}
            //List<int> listSum = new List<int>();
            //listSum.AddRange(listJi);
            //listSum.AddRange(listOu);


            //foreach (int  item in listSum )
            //{
            //    Console.Write(item);
            //}
            //Console.ReadKey();

            //Console.WriteLine("zifuchuan");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input )
            //{
            //    chs[i] = item;
            //    i++;
            //}

            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            string str = "Welcome come to China";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }

            }

            foreach (KeyValuePair <char ,int > kv in dic )
            {
                Console.WriteLine("{0},{1}ci",kv.Key,kv .Value );
            }

            Console.ReadKey();
        }
    }
}
