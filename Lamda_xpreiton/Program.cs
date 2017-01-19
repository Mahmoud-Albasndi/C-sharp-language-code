using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using  System.Diagnostics;
namespace Lamda_xpreiton
{
    delegate bool MyNumber(int Number);
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber n1 = (x => x > 10 );

            int[] MyAraay = { 4, 5, 7, 8, 11, 14, 17, 1, 19, 27 };
            for (int i = 0; i < MyAraay.Length; i++)
            {
                  if (MyAraay[i] > 10)
                WriteLine($"{MyAraay[i]}");
            }

            //Func<int, bool> func2 = (x => x > 10);
            //int[] MyAraay = { 4, 5, 7, 8, 11, 14, 17, 1, 19, 27 };
            //for(int i = 0; i < MyAraay.Length; i++)
            //{
            //    if (MyAraay[i] > 10)
            //     Debug.WriteLine(MyAraay[i]);
            //}
            ReadKey();






            ReadKey();
        }
    }
}
