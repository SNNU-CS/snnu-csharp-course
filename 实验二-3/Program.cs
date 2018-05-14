using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("41612164_赵旗");
            string[] str = { "abc", "gdef", "hghi", "kjkl" };
            Console.WriteLine("--------Origin---------");
            PrintArray(str);
            Console.Write(str);

            Console.WriteLine("--------Sort---------");
            Array.Sort(str);
            PrintArray(str);

            Console.WriteLine("----------Reverse-------");
            Array.Reverse(str);
            PrintArray(str);

            Console.WriteLine("The position for \"abc\" is:{0}", Array.IndexOf(str,"abc"));
            Console.WriteLine("The array contains \"abc\":{0}", str.Contains("abc") ? true : false);
            Console.Read();
        }
        public static void PrintArray(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
                Console.Write("{0}\t",str[i]);
            Console.WriteLine();
        }
    }
}
