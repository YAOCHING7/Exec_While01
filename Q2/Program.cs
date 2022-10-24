using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
		static void Main(string[] args)
		{
			int num = 300;
			int i = 1;
			while (i <= 300)
			{
				if (num % i == 0)
				{
					Console.WriteLine(i);

				}
				i++;
			}
		}
    }
}
