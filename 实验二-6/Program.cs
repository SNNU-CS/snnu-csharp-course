using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("41612164_赵旗");
            int []number = { 1, 2, 3 };
            for (int i = 0; i < 4; i++)
            {
                Console.Write("number({0}):", i);
                try
                {
                    Console.Write("{0}", number[i]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("-----------------");
            int a=9, b=0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
