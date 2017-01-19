using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class Managers:Employee
    {
        public string managaer = "I am manager" ;

        public override void printEmloyees()
        {
            Console.WriteLine($"{managaer}");
        }

    }
}
