using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triangle_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 1;
            long triangleNumber = MaxDivisors(number);
            Console.WriteLine($"The first triangle number to have over five hundred divisors is: {triangleNumber}");
        }

        public static long MaxDivisors(long number)
        {
            int count = 1;
            int maxDivisors1 = 500;

            for (long i = 2; i < long.MaxValue; i++)
            {
                number += i;
                count = ReturnDivisor(number);
                if (count > maxDivisors1)
                {
                    break;
                }
                count = 1;
            }
            return number;
        }

        public static int ReturnDivisor(long number)
        {
            int divisor = 1;
            
            for (int j = 2; j <= number; j++)
            {
                int count = 1;
                while (number % j == 0)
                {
                    number /= j;
                    count++;
                }
                divisor *= count;
            }
            return divisor;
        }
    }
}
