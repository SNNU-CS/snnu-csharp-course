using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("41612164_赵旗");
            Console.WriteLine("1+2+…+n<9,n？");
            int sum = 0;
            for(int n=1;; n++)
            {
                sum += n;
                if (sum < 9)
                    Console.WriteLine("n:{0} ", n);
                else
                    break;
            }
            Console.Read();
        }
    }
}
