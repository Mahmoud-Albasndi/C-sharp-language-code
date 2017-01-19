using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    class Program
    {
        static void Main(string[] args)
        {
            Person PeObj = new Person();
            Employee EmpObj = new Employee();
            Managers ManObj = new Managers();
            Financial finObj = new Financial();
            HR HoObj = new HR();

            PeObj.printPerson();
        
            //EmpObj.printEmloyees();
            //ManObj.printEmloyees();
            //finObj.printEmloyees();
             HoObj.printEmloyees();
          
            
            Console.ReadKey();

        }
    }
}
