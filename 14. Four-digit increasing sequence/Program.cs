using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Four_digit_increasing_sequence
{
    class Program
    {
        public static void Main()
        {
            List<int> primes = Primes();
            List<int> permute = PrimeNumber(primes);
            Console.Write("12-digit number is: ");
            for (int i = 0; i < permute.Count; i++)
            {
                Console.Write($"{permute[i]}");
            }

            Console.ReadLine();
        }
        public static List<int> PrimeNumber(List<int> primes)
        {
            List<int> addPermutation = new List<int>();
            int subtract = 0;
            bool isPermute = false;
            for (int i = 0; i < primes.Count; i++)
            {
                for (int j =  i + 1; j < primes.Count; j++)
                {
                    isPermute = IsPerm(primes[i], primes[j]);
                    if (isPermute)
                    {
                        subtract = primes[j] - primes[i];
                        addPermutation.Add(primes[i]);
                        for (int k = j + 1; k < primes.Count; k++)
                        {
                            isPermute = IsPerm(primes[j], primes[k]);
                            if(isPermute)
                            {
                                addPermutation.Add(primes[j]);
                                if(subtract == (primes[k] - primes[j]))
                                {
                                    addPermutation.Add(primes[k]);
                                    return addPermutation;
                                }
                            }
                        }
                        addPermutation.Clear();
                        break;
                    }
                }
            }
                       
            return addPermutation;
        }
        public static List<int> Primes()
        {
            List<int> primes = new List<int>();
            bool isPrime = false;
            for (int i = 1000; i < 10000; i++)
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
        private static bool IsPerm(int m, int n)//This is not my algorithm. This is from the net.
        {
            int[] arr = new int[10];

            int temp = n;
            while (temp > 0)
            {
                arr[temp % 10]++;
                temp /= 10;
            }

            temp = m;
            while (temp > 0)
            {
                arr[temp % 10]--;
                temp /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
