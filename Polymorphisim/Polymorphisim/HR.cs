using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class HR:Employee
    {
        public string Department = "I am from Human resources Department";

        public override void printEmloyees()
        {
            Console.WriteLine($"{Department}");
        }

    }
}
