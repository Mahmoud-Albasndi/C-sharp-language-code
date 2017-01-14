using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InhertanceClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is class disgram  


            Employees MyObj = new Employees();
             MyObj.PrintPerson();
             MyObj.PrintEmployee();
             MyObj.DePartmanet = "Financial";
             Console.WriteLine($" work in departmanet = {MyObj.DePartmanet}");
         
          
        
            Console.ReadKey();
        }
    }
}
