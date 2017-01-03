using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Smallest_positive_integer_2x__3x__4x__5x__6x
{
    class Program
    {
        static void Main(string[] args)
        {
            long smallestEqual = GetSmallestInteger();
            Console.WriteLine($"Smallest positive integer, x, such that \n2x, 3x, 4x, 5x, and 6x, which contains the same digits is: {smallestEqual}");
            Console.ReadLine();
        }
        public static long GetSmallestInteger()
        {
            List<long> equalDigits = new List<long>();
            bool isEqual = false;
            for (long i = 10; i < 10000000; i++)
            {
                equalDigits.Add(i);
                for (int j = 2; j < 7; j++)
                {
                    if(equalDigits.Count == 0)
                    {
                        break;
                    }
                    isEqual = EqualGigit(i, i * j);
                    if (isEqual)
                    {
                        equalDigits.Add(i * j);
                    }
                    else
                    {
                        equalDigits.Clear();
                    }
                }
                if(equalDigits.Count != 0)
                {
                    return i;
                }
            }
            return 0;
        }
       public static bool EqualGigit(long number, long addNumber)
        {
            long[] array = new long[10]; 
            long temp = number;
            while(temp > 0)
            {
                array[temp % 10]++;
                temp /= 10;
            }

            temp = addNumber;
            while (temp > 0)
            {
                array[temp % 10]--;
                temp /= 10;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
