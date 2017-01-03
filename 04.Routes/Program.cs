using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Routes
{
    class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 20 + 20;
            BigInteger factorial = 1;
            BigInteger factorial20 = 1;
            for (int i = gridSize; i >= 1; i--)
            {
                factorial *= i;
                if(i <= 20)
                {
                    factorial20 *= i;
                }
            }
            BigInteger finalFactorial = (factorial / factorial20) / factorial20;
            Console.WriteLine($"20x20 grid have {finalFactorial} routes.");
            Console.ReadLine();
           
        }
    }
}
