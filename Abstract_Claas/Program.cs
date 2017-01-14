using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Claas
{
    class Program
    {
        static void Main(string[] args)
        {

           //you must call Class son to print result

            Toyota MyObj = new Toyota();

            MyObj.model = "Rav4";
            MyObj.make = "Camry";
            MyObj.enginesize = 4;

            MyObj.Printmodel();
            MyObj.Printmake();
            MyObj.Printanginesize();

            Console.ReadKey();
        }
    }
}
