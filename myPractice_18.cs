using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsStudent = new Person("张三",18,'女',99,99,99);
            //zsStudent.Name = "张三";
            //zsStudent.Age = 21;
            //zsStudent.Gender = '女';
            //zsStudent.Chines = 100;
            //zsStudent.Math = -20;
            //zsStudent.English = 99;
            zsStudent.SayHello();
            zsStudent.ShowScore();
            


            Person lhStudent = new Person("李华",21,'男');
            //zsStudent.Name = "张三";
            //zsStudent.Age = 21;
            //zsStudent.Gender = '女';
            //zsStudent.Chines = 100;
            //zsStudent.Math = -20;
            //zsStudent.English = 99;
            lhStudent.SayHello();
            lhStudent.ShowScore();
           


            Person zsPerson = new Person("张三", 21);
            zsPerson.SayHello();
            Console.ReadKey();
        }
    }
}
