using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class Employee:Person
    {
        public int age = 24;

        public virtual void printEmloyees()
        {
            Console.WriteLine($"the age is = {age}");
        }
         
    }
}
