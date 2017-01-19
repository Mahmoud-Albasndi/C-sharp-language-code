using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ParamsReference
{
    class Program
    {
        static int MyNumber (params int[] Numbre)
        {
            WriteLine($"You sent my = {Numbre.Length}");
            int MixValu = 0;
            if (Numbre.Length == 0)
                return MixValu;
            for (int i = 0; i < Numbre.Length; i++)
            {
                MixValu = Numbre.Max();
            }
                return MixValu; 
        }
        static void Main(string[] args)
        {
            int Mix;
            Mix = MyNumber( 4, 5, 6, 90 , 8, 9, 18, 29);
            WriteLine($"The Mix Value is = {Mix}\n");
      
            int[] MyAraay = { 6, 7, 9, 15, 80, 52, 74 };
            Mix = MyNumber(MyAraay);
            WriteLine($"The Mix Value of Array = {Mix}\n");
            WriteLine($"The Value sent my = {MyNumber()}");
            ReadKey();
        }
    }
}
