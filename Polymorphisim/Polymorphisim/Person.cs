using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class Person
    {
        public string name = "Mahmoud Albasndi";
        public string address = "jordan";

        public void printPerson() { Console.WriteLine($"my name is  = {name}\naddress in =  {address}"); }

    }
}
