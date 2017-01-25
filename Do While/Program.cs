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
            
                   double mySalary = 1000.20, total = 0.0;
            int i = 0;
            do
            {
               total +=  mySalary;   //total = total  + mySalary;
               i++;
                Console.WriteLine("i values equal {0}",i);
            } while (i < 10);
            Console.WriteLine("Salary values equal {0}", total);

          
            
            //    int i = 0;
            //    do
            //    {
            //        i += 15;
            //        i++;

            //    } while (i < 5);
            //    Console.Write($"{i}");

            
            }
           Console.ReadKey();
        }
    }
}
