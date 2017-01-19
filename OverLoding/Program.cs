using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoding
{
    class Program
    {
        
        public static int minVal(int []MyAraay)
        {
            int Number = MyAraay[0];
            for (int i = 1; i < MyAraay.Length; i++)
            {
                if (MyAraay[i] < Number)
                     Number = MyAraay[i];
            }    
            return Number;
        }
        public static double minVal(double MyAraay)
        {
            return MyAraay;
        } 

        static void Main(string[] args)
        {
            int[] MyAraay = {19, 20, 30, 44, 5, 6, 7, 8, 9, 10};
            Console.WriteLine($"The minumim Value is = {minVal(MyAraay)}");
            Console.ReadKey();
            
        }
    }
}
