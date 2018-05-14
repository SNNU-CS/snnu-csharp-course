using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二_4
{
    class Program
    {
        public static int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public static int Add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("41612164_赵旗");
            int a = 6, b = 8, c = 9;
            Console.WriteLine("两个数相加:{0}+{1}:{2}",a,b,Add(a, b));
            Console.WriteLine("三个数相加:{0}+{1}+{2}:{3}", a,b,c,Add(a, b, c));
            Console.Read();
        }
    }
}
