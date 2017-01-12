using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace _21.Lychrel_numbers
{
    class Program
    {
        public static void Main()
        {
            Stopwatch clock = Stopwatch.StartNew();
            BigInteger number = 0;
            BigInteger secondNumber = 0;
            BigInteger thirdNumber = 0;
            BigInteger forthNumber = 0;
            int firstNumber = 1;
            bool isPalindrom = false;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            while (firstNumber < 10000)
            {
                number = firstNumber;
                for (int i = 1; i < 50; i++)
                {
                    secondNumber = number;
                    for (BigInteger j = number; j > 0; j /= 10)
                    {
                        number = j % 10;
                        sb.Append(number);
                    }
                    
                    number = BigInteger.Parse(sb.ToString());
                    sb.Clear();
                    thirdNumber = number + secondNumber;
                    forthNumber = thirdNumber;
                    for (BigInteger j = thirdNumber; j > 0; j /= 10)
                    {
                        thirdNumber = j % 10;
                        sb.Append(thirdNumber);
                    }
                    thirdNumber = BigInteger.Parse(sb.ToString());
                    if (forthNumber == thirdNumber)
                    {
                        isPalindrom = true;
                        break;
                    }
                    else
                    {
                        number += secondNumber;
                        isPalindrom = false;
                    }
                    sb.Clear();

                }
                if (isPalindrom)
                {
                    firstNumber++;
                    sb.Clear();
                    continue;
                }
                else
                {
                    count++;
                }

                firstNumber++;
                sb.Clear();
            }
            clock.Stop();
            Console.WriteLine(count);
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
        }

        //public static int IsPalindrome(int number, int palindrome)
        //{
        //    int sum = number + palindrome;
        //    string text = sum.ToString();
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = sum.ToString().Length - 1; i >= 0; i--)
        //    {
        //        sb.Append(sum.ToString()[i]);
        //    }
        //    sb.ToString();
        //    for (int i = 0; i < 50; i++)
        //    {
        //        if (text == sb.ToString())
        //        {
        //            return 0;
        //        }
        //    }

        //    return 1;
        //}
    }
}
