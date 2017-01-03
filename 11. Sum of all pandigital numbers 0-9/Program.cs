using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sum_of_all_pandigital_numbers_0_9
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            for (long i = 1023456789; i < 9876543211; i++)
            {
                if (i % 9 != 0)
                {
                    continue;
                }
                if (Pandigital(i) != 0)
                {             
                    sum += PandigitalProperty(i);
                }
            }
            Console.WriteLine($"The sum of all 0 to 9 pandigital numbers is: {sum}");
            Console.ReadLine();
        }

        public static long Pandigital(long number)
        {
            StringBuilder text = new StringBuilder();
            text.Append(number.ToString());

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if ((int)Char.GetNumericValue(text[i]) == (int)Char.GetNumericValue(text[j]))
                    {
                        return 0;
                    }
                }
            }
                return number;
        }
        public static long PandigitalProperty(long panDigital)
        {
            List<int> primes = Primes();
            string text = panDigital.ToString();
            bool isPandigital = false;
            for (int i = 1; i < 8; i++)
            {
               int number = Convert.ToInt32(text.Substring(i, 3));
                if (number % primes[i - 1] == 0)
                {
                    isPandigital = true;
                }
                else
                {
                    return 0;
                }
            }
            if(isPandigital)
            {
                return panDigital;
            }
            else
            {
                return 0;
            }
            
        }
        public static List<int> Primes()
        {
            List<int> primes = new List<int>();

            for (int i = 2; i < 18; i++)
            {
                if(i == 2 || i == 3)
                {
                    primes.Add(i);
                    continue;
                }
                if(i % 2 == 0 || i % 3 == 0)
                {
                    continue;
                }
                primes.Add(i);
            }
            return primes;
        }
    }
}
