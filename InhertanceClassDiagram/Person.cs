using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InhertanceClassDiagram
{
    public class Person
    {
        public int Age = 24;
        public string Gender = "Male";

     
        public void PrintPerson()
        {
            Console.WriteLine($"This is person = {Gender}\nThis is person old {Age}");
        }
    }
}