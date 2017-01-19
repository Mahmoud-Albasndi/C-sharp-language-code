using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class Financial:Employee
    {
        public string financial  = "I am from financial departmanet";

            public override void printEmloyees()
        {
            Console.WriteLine($"{financial}");
        }

    }
}
