using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InhertanceClassDiagram
{
    public class Employees : Person
    {
        public string DePartmanet;
        public string Address = "Amman jordan";
        public string Name = "Ahmad Ali";
        public double Salary = 1200.99;

        public void PrintEmployee()
        {
            Console.WriteLine($"\n\n name for emploee = {Name}\n Live in = {Address}\n salary for emoloyee is = {Salary}");
        }

    }
}