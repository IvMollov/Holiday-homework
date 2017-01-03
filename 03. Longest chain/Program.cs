using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Longest_chain
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int tempCount = 1;
            long number = 0;
            for (int i = 999999; i >= 1; i--)
            {
                tempCount = LongestChain(i);
                if (tempCount > count)
                {
                    count = tempCount;
                    number = i;
                }
            }

            Console.WriteLine($"Number {number} produces the longest chain: {count}");
            Console.ReadLine();
        }

        public static int LongestChain(long number)
        {
            int tempCount = 1;
            while(number > 1)
            {
                if(number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = (3 * number) + 1;
                }
                tempCount++;
            }

            return tempCount;
        }
    }
}
