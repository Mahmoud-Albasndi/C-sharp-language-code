using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Claas
{
    class Toyota:Cars
    {


        public override void Printmodel()
        {
            Console.WriteLine($"The modle car is = {model}");
        }
        public override void Printmake()
        {
            Console.WriteLine($"Vehicle Type is = {make}");
        }
        public override void Printanginesize()
        {
            Console.WriteLine($"Engin size is = {enginesize}");
        }

    }
}
