using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Truncatable_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prime = Prime();
            int sum = TruncatablePrimes(prime);
            Console.WriteLine($"The sum of all primes that are both \ntruncatable from left to right and right to left is: {sum}");
            Console.ReadLine();
        }
        public static List<int> Prime()
        {
            List<int> prime = new List<int>();
            int sum = 0;
            int number = 0;
            bool isPrime = true;

            for (int i = 2; i < 1000000; i++)
            {
                sum = 0;

                if ((i > 2 && i % 2 == 0) || (i > 5 && i % 10 == 5))
                {
                    continue;
                }

                number = i;
                for (int j = i; j > 0; j /= 10)
                {
                    number = j % 10;
                    sum += number;
                }
                if (i > 3 && sum % 3 == 0)
                {
                    continue;
                }

                for (int k = 0; k < prime.Count; k++)
                {
                    if (i % prime[k] == 0)
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
        public static int TruncatablePrimes(List<int> primes)
        {
            int sum = 0;
            int value = 0;
            bool isRight = false;
            bool isLeft = false;
            string textValue = "";
            
            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = primes[i]; j > 0; j /= 10)
                {
                    value = j / 10;
                   isRight = RightTruncatable(value, primes);
                    if(!isRight)
                    {
                        break;
                    }
                }

                textValue = primes[i].ToString();
                for (int k = 0; k < textValue.Length - 1; k++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = k + 1; j < textValue.Length; j++)
                    {
                        sb.Append(textValue[j]);

                    }
                    sb.ToString();
                    isLeft = RightTruncatable(Convert.ToInt32(sb.ToString()), primes);
                    if (!isLeft)
                    {
                        break;
                    }
                }

                if(primes[i] == 2 || primes[i] == 3 || primes[i] == 5 || primes[i] == 7)
                {
                    sum = 0;
                    continue;
                }
                if(isLeft && isRight)
                {
                    sum += primes[i];
                }              
            }
            return sum;
        }
        public static bool RightTruncatable(int value, List<int> primes)
        {          
            for (int i = 0; i < primes.Count; i++)
            {
                if(value == 2 || value == 3 || value == 5 || value == 7 || value == 0 )
                {
                    return true;
                }
                if (value == primes[i])
                {
                    return true;
                }
                if (value < primes[i])
                {
                    return false;
                }
            }
            return false;
        }
    }
}
