using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("41612164_赵旗");

            //switch
            Console.WriteLine("Please input a char.");
            char str = Convert.ToChar(Console.ReadLine());
            switch ((str >= 'A' && str <= 'Z') || (str >= 'a' && str <= 'z'))
            {
                case true:
                    Console.WriteLine("输入的字符为字母！");
                    break;
                case false:
                    Console.WriteLine("输入的字符不是字母！");
                    break;
            }
            //Console.Read();
            //for
            int password = 66;
            Console.Write("请输入你猜的密码:");
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number != password)
                {
                    if (number < password)
                        Console.WriteLine("你猜小了！");
                    else
                        Console.WriteLine("你猜大了！");
                }
                else
                {
                    Console.WriteLine("恭喜你，猜对了！");
                    Console.Read();
                    break;
                }
            }
        }
    }
}
