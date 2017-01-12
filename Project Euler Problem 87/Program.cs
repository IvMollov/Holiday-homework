using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem_87
{
    class Program
    {
        public static void Main()
        {
            long result = 0;
            double second = 2;
            double third = 3;
            double forth = 4;
            int count = 0;
            bool isFound = false;
            List<long> primes = Primes();
            List<long> powerSecond = new List<long>();
            List<long> powerThird = new List<long>();
            List<long> powerForth = new List<long>();
            SortedSet<long> final = new SortedSet<long>();
            for (int i = 0; i < primes.Count; i++)
            {
                powerSecond.Add((long)(Math.Pow(primes[i], second)));
                for (int j = 0; j < primes.IndexOf(373); j++)
                {
                    powerThird.Add((long)(Math.Pow(primes[j], third)));
                    for (int k = 0; k < primes.IndexOf(89); k++)
                    {
                        powerForth.Add((long)(Math.Pow(primes[k], forth)));
                        result = powerSecond[i] + powerThird[j] + powerForth[k];
                        if (result > 50000000)
                        {
                            break;
                        }
                        final.Add(result);

                    }
                }
            }

            Console.WriteLine("The result is {0}", final.Count);

        }

        public static List<long> Primes()
        {
            List<long> primes = new List<long>();
            bool isPrime = false;
            for (int i = 1; i < 7073; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if (i == 2)
                {
                    primes.Add(i);
                }
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
