using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Palindromic_decimal_and_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if(PalindromicDecimal(i) && PalindromicBinary(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of all numbers, less than one million, which \nare palindromic in base 10 and base 2 is: {sum}.");

            Console.ReadLine();
        }
        public static bool PalindromicDecimal(int number)
        {
            StringBuilder textNumber = new StringBuilder();
            int value = 0;
            for (int i = number; i > 0; i /= 10)
            {
                value = i % 10;
                textNumber.Append(value);
            }
            string decimalNumber = textNumber.ToString();
            int newNumber = Convert.ToInt32(decimalNumber);
            if(newNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PalindromicBinary(int number)
        {
            StringBuilder textNumber = new StringBuilder();
            string binary = Convert.ToString(number, 2);
            for (int i = binary.Length - 1; i >= 0; i--)
            {                
                textNumber.Append(binary[i]);
            }

            if (binary == textNumber.ToString())
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
