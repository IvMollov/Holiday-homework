using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Circular_prime
{
   class Program
    {
        static void Main(string[] args)
        {
            //    List<int> a = Prime();
            //    int sum = CircularPrime(a);
            //    Console.WriteLine(sum);
            int count = CircularPrimes();
            Console.WriteLine($"How many circular primes are there below one million? {count}");

            Console.ReadLine();
        }
        //public static List<int> Prime()
        //{
        //    List<int> prime = new List<int>();
        //    int sum = 0;
        //    int number = 0;
        //    bool isPrime = true;
        //    for (int i = 2; i < 1000000; i++)
        //    {
        //        sum = 0;
        //        if ((i > 2 && i % 2 == 0) || (i > 5 && i % 10 == 5))
        //        {
        //            continue;
        //        }
        //        number = i;
        //        for (int j = i; j > 0; j /= 10)
        //        {
        //            number = j % 10;
        //            sum += number;
        //        }
        //        if (i > 3 && sum % 3 == 0)
        //        {
        //            continue;
        //        }
        //        for (int k = 0; k < prime.Count; k++)
        //        {
        //            if (i % prime[k] == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //            isPrime = true;
        //        }
        //        if (isPrime)
        //        {
        //            prime.Add(i);
        //        }
        //    }

        //    return prime;
        //}
        //public static int CircularPrime(List<int> prime)
        //{
        //    int multiplier = 1;
        //    int number = 0;
        //    int count = 0;
        //    int newNumber = 0;
        //    int sum = 0;
        //    List<int> foundCircularPrimes = new List<int>();
        //    for (int i = 0; i < prime.Count; i++)
        //    {
        //        for (int j = prime[i]; j > 0; j /= 10)
        //        {
        //            number = j;
        //            if (j == 2 || j == 5)
        //            {
        //                count++;
        //                break;
        //            }
        //            number = j % 10;
        //            if(number % 2 == 0 || number == 5)
        //            {
        //                prime.Remove(number);
        //                return 0;
        //            }
        //            multiplier *= 10;
        //            count++;
        //        }
        //        multiplier /= 10;
        //        number = prime[i];

        //        for (int k = 0; k < count; k++)
        //        {
        //            if (prime.Contains(number))
        //            {
        //                foundCircularPrimes.Add(number);
        //            }
        //            else if (!foundCircularPrimes.Contains(number))
        //            {
        //                return 0;
        //            }

        //            newNumber = number % 10;
        //            number = newNumber * multiplier + number / 10;
        //        }

        //        sum += count;
        //    }
        //    return sum;
        //}

        public static Boolean IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }                  
            }
            return true;
        }
        public static int CircularPrimes()
        {
            int result = 0;

            for (int i =1; i < 1000000; i++)
            {
                bool isCircularPrime = true;
                string digits = i.ToString();

                for (int j = 0; j < digits.Length; j++)
                {
                    int number = int.Parse(digits);

                    if (IsPrime(number) == false)
                    {
                        isCircularPrime = false;
                        break;
                    }

                    digits = RotateNumber(digits);
                }

                if (isCircularPrime)
                    result++;
            }

            return result;
        }
        public static string RotateNumber(string number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < number.Length; i++)
            {
                sb.Append(number.Substring(i, 1));
            }
            sb.Append(number[0]);

            return sb.ToString();
        }
    }
}
