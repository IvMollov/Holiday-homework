using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Four_consecutive_numbers
{
    class Program
    {
        static List<int> factors = new List<int>();
        static int[] numbers = new int[4];

        static void Main(string[] args)
        {
            List<int> primes = Prime();
            FourPrimeFactors(primes);
            Console.WriteLine("The first four consecutive integers to \nhave four distinct prime factors each are: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Number: {0} ", numbers[i]);
            }
            Console.ReadLine();
        }
        public static void FourPrimeFactors(List<int> primes)
        {
            List<int> foundPrimes = new List<int>();
            int number = 0;

            for (int i = 2 * 3 * 5 * 7; i < 200000; i++)
            {
                int start = 0;
                if (factors.Count == 4)
                {
                    start = 4;
                }
                if (factors.Count == 8)
                {
                    start = 8;
                }
                if (factors.Count == 12)
                {
                    start = 12;
                }

                if (factors.Count == 16)
                {
                    for (int b = 0; b < numbers.Length; b++)
                    {
                        numbers[b] = i - b - 1;
                    }
                }

                number = i;
                int size = 0;
                int count = 0;

                for (int j = number; j > 0; j/= size)
                {
                   size = PrimeFactor(j, primes, start);
                    if(size == 0)
                    {
                        break;
                    }
                    count++;
                }
 
                if(factors.Count % 4 != 0 || count < 4)
                {
                    factors.Clear();
                }
            }
        }

        public static int PrimeFactor(int number, List<int> primes, int start)
        {
            for (int i = 0; i < primes.Count; i++)
            {
                if (number % primes[i] == 0)
                {
                    for (int j = start; j < factors.Count; j++)
                    {
                        if (primes[i] == factors[j])
                        {
                            return primes[i];                         
                        }
                    }
                    factors.Add(primes[i]);
                    return primes[i];
                }
                if(primes[i] > number)
                {
                    return 0;
                }
            }
            return 0;
        }

        public static List<int> Prime()
        {
            List<int> prime = new List<int>();
            bool isPrime = false;
            for (int i = 1; i < 10000; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if (i == 2)
                {
                    prime.Add(i);
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
                    prime.Add(i);
                }
            }
            return prime;
        }
    }
}
