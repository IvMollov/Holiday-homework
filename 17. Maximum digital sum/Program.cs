using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _17.Maximum_digital_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "";
            int max = 0;
            int tempMax = 0;
            for (BigInteger i = 99; i > 0; i--)
            {
                BigInteger number = i;
                for (int j = 95; j > 0; j--)
                {
                    number *= i;

                    text = number.ToString();
                    tempMax = DigitalSum(text);
                    if (tempMax > max)
                    {
                        max = tempMax;
                    }
                }                
            }         

            Console.WriteLine($"The maximum digital sum of natural number of the form, a^b, \nwhere a, b < 100 is: {max}");

            Console.ReadLine();
        }

        public static int DigitalSum(string number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += (int)Char.GetNumericValue(number[i]);
            }

            return sum;
        }
    }
}
