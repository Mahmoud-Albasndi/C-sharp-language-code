using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int i = 0;
            //    do
            //    {
            //        i += 15;
            //        i++;

            //    } while (i < 5);
            //    Console.Write($"{i}");

            int[][] MyArray = new int[2][];

             MyArray[0] = new int [6]{ 7, 10, 12, 14, 18, 19 };
             MyArray[1] = new int [6] { 1, 2, 4, 5, 8, 7 };
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"Elment{i}");

                for (int j = 0; j < MyArray[i].Length; j++)
                {
                    Console.WriteLine("{0}" ,MyArray[i][j] + " ");
                }
                Console.WriteLine();
            }
           Console.ReadKey();
        }
    }
}
