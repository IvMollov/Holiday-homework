using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_125
{
    class Program
    {
        public static void Main()
        {
            int limit = 100000000;
            double sqrtLimit = Math.Sqrt(limit);
            long sum = 0;
            SortedSet<long> palindromic = new SortedSet<long>();
            for (int i = 1; i <= sqrtLimit; i++)
            {
                int number = i * i;
                for (int j = i + 1; j <= sqrtLimit; j++)
                {
                    number += j * j;
                    if (number > limit)
                    {
                        break;
                    }
                    if (IsPalindrome(number) && !palindromic.Contains(number))
                    {
                        sum += number;
                        palindromic.Add(number);
                    }
                }
            }
            Console.WriteLine("The sum is: {0}", sum);
            Console.ReadLine();
        }

        public static bool IsPalindrome(long value)
        {
            string numberToText = value.ToString();
            StringBuilder palindrome = new StringBuilder();
            for (int i = numberToText.Length - 1; i >= 0; i--)
            {
                palindrome.Append(numberToText[i]);
            }
            if (numberToText == palindrome.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
