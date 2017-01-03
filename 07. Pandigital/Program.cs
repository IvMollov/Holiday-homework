using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pandigital
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            long sum = 0;
            List<int> products = new List<int>();
            for (int i = 9999; i > 1; i--)
            {
                for (int j = 100; j < 9999; j++)
                {
                    if (i % j == 0)
                    {
                        number = i / j;

                        if (Pandigital(number, i, j) != 0)
                        {
                            products.Add(Pandigital(number, i, j));
                        }
                    }
                }
            }
            for (int i = 0; i < products.Count; i++)
            {
                sum += products[i];
                for (int j = 0; j < i; j++)
                {
                    if (products[i] == products[j])
                    {
                        sum -= products[i];
                        break;
                    }
                }
            }

            Console.WriteLine("The sum of all products whose multiplicand/multiplier/product\n" +
                 $"identity can be written as a 1 through 9 pandigital is: {sum}");

            Console.ReadLine();
        }

        public static int Pandigital(int multiplicand, int product, int multiplier)
        {
            StringBuilder text = new StringBuilder();
            text.Append(multiplicand.ToString() + multiplier.ToString() + product.ToString());
            int[] panDigital = new int[text.Length];
            int[] panDigitalCheck = new int[text.Length];
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if((int)Char.GetNumericValue(text[i]) == j)
                    {
                        panDigital[i] = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < panDigital.Length; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (panDigital[i] == j)
                    {
                        panDigitalCheck[i] = 1;
                        for (int k = 0; k < i; k++)
                        {
                            if (j == panDigital[k])
                            {
                                panDigitalCheck[i] = 0;
                                break;
                            }
                        }                        
                        break;
                    }
                }
            }
            for (int i = 0; i < panDigitalCheck.Length; i++)
            {
                if(panDigitalCheck[i] == 1)
                {
                    count++;
                }
            }

            if(count == 9)
            {          
                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}
