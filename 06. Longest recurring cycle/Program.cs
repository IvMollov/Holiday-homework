using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Longest_recurring_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = 0;
            int number = 0;

            for (int i = 1000; i > 1; i--)
            {
                if (sequenceLength >= i)
                {                   
                    break;
                }

                int[] foundRemainders = new int[i];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    sequenceLength = position - foundRemainders[value];
                    number = i;
                }
            }

            Console.WriteLine($"Number {number} has longest recurring cycle: {sequenceLength}");
        }

    }
}
