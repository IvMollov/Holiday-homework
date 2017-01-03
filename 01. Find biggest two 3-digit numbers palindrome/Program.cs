using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_biggest_two_3_digit_numbers_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 999;
            int pal = Palindrome(number);
            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is: {pal}");

            Console.ReadLine();
        }

        public static int Palindrome(int number)
        {
            string numberToText = string.Empty;
            int product = 0;
            int max = 0;
            int tempMax = 0;
            StringBuilder palindrome = new StringBuilder();
            for (int i = number; i > 100; i--)
            {
                for (int k = i; k >= 100; k--)
                {
                    product = k * i;
                    numberToText = product.ToString();

                    for (int j = numberToText.Length - 1; j >= 0; j--)
                    {
                        palindrome.Append(numberToText[j]);
                    }

                    if (palindrome.ToString() == numberToText)
                    {
                        tempMax = product;
                        if (tempMax > max)
                        {
                            max = tempMax;
                        }
                    }
                    palindrome.Clear();
                }
            }

            return max;
        }
      }
   }

