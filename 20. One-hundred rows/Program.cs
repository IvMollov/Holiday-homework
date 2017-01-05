using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;


namespace _20.One_hundred_rows
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"D:\Projects\Holiday homework\Holiday-homework\20. One-hundred rows\input.txt";
            int[,] inputTriangle = ReadInput(filename);
            int lines = inputTriangle.GetLength(0);
            int[] largestValues = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                largestValues[i] = inputTriangle[lines - 1, i];
            }

            for (int i = inputTriangle.GetLength(0) - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    largestValues[j] = inputTriangle[i, j] + Math.Max(largestValues[j], largestValues[j + 1]);
                }
            }

            Console.WriteLine("The largest sum through the triangle is: {0}", largestValues[0]);
        }
        private static int[,] ReadInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader r = new StreamReader(filename);
            while ((line = r.ReadLine()) != null)
            {
                lines++;
            }

            int[,] inputTriangle = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputTriangle[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputTriangle;
        }
    }
}
