using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.How_many_sundays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (DateTime i = new DateTime(1901, 01, 01); i < new DateTime(2000, 12, 31);  i = i.AddDays(1))
            {
                if(i.DayOfWeek == DayOfWeek.Sunday && i.Day == 1 )
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} Sundays on the first of the month during the twentieth century.");

            Console.ReadLine();
        }
    }
}
