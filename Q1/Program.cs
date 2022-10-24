using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num * (num + 1) / 2 < 105)
            {
                num++;

            }
            Console.WriteLine(num - 1);
        }
    }
}
