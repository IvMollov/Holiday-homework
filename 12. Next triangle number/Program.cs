using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _12.Next_triangle_number
{
    class Program
    {
        static void Main(string[] args)
        {           
            long sum = 0;
            List<long> triangle = TriangleNumber();
            List<long> pentagonal = PentagonalNumber();
            List<long> hexagonal =HexagonalNumber();
            for (int i = 0; i < triangle.Count; i++)
            {
                for (int j = 0; j < pentagonal.Count; j++)
                {
                    if(triangle[i] == pentagonal[j])
                    {
                        for (int k = 0; k < hexagonal.Count; k++)
                        {
                            if((triangle[i] == hexagonal[k]) && (pentagonal[j] == hexagonal[k]))
                            {
                                sum = triangle[i];                               
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"The next triangle number that is also pentagonal and hexagonal is: {sum}");
            Console.ReadLine();
        }
        public static List<long> TriangleNumber()
        {
            long sum = 0;
            List<long> triangleNumbers = new List<long>();
            for (long i = 286; i < 60000; i++)
            {
                sum = (i * (i + 1)) / 2;
                triangleNumbers.Add(sum);
            }
            return triangleNumbers;
        }
        public static List<long> PentagonalNumber()
        {
            long sum = 0;
            List<long> pentagonalNumbers = new List<long>();
            for (long i = 166; i < 45000; i++)
            {
                sum = (i * (3 * i - 1)) / 2;
                pentagonalNumbers.Add(sum);
            }

            return pentagonalNumbers;
        }
        public static List<long> HexagonalNumber()
        {
            long sum = 0;
            List<long> hexagonalNumbers = new List<long>();
            for (long i = 144; i < 30000; i++)
            {
                sum = (i * (2 * i - 1));
                hexagonalNumbers.Add(sum);
            }
            return hexagonalNumbers;
        }
    }
}
