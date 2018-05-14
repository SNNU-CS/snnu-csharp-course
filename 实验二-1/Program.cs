using System;

namespace 实验二_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本输出
            Console.WriteLine("41612164_赵旗");

            //基本输入
            Console.WriteLine("Please input a string！");
            String s = Console.ReadLine();
            Console.WriteLine(s);

            //输出日期
            DateTime dt = new DateTime(2018, 03, 29, 19, 10, 06);
            Console.WriteLine(dt.ToString());
            Console.Read();
        }
    }
}
