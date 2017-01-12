using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_145
{
    class Program
    {
        public static void Main()
        {
            long reversedNumber = 0;
            long sum = 0;
            int count = 0;
            for (long i = 1; i < 100000000; i++)
            {
                reversedNumber = Reverse(i);
                sum = reversedNumber + i;
                if (Reversible(sum))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static long Reverse(long number)
        {
            StringBuilder text = new StringBuilder();
            long copyNumber = number;
            for (long i = number; i > 0; i /= 10)
            {
                copyNumber = i % 10;
                text.Append(copyNumber);
                if ((int)Char.GetNumericValue(text[0]) == 0)
                {
                    return number;
                }
            }
            return Convert.ToInt64(text.ToString());
        }
        public static bool Reversible(long number)
        {

            long copyNumber = number;
            for (long i = number; i > 0; i /= 10)
            {
                copyNumber = i % 10;
                if (copyNumber % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
