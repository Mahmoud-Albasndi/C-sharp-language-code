using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePart myEmloyee = new EmployeePart();
            myEmloyee.PrintName();
            myEmloyee.PrintAdress();
            myEmloyee.PrintDepartment();
            Console.ReadKey();
        }
    }
}
