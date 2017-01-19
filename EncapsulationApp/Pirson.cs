using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    class Pirson
    {
        private string name;
        private int age;
        public void Printvalue() { Console.WriteLine($"Name is = {name} Age = {age}"); }

        public Pirson() { }
        public void pirson(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge (int Myage)
        {
            age = Myage;
        }
        public int GetAge()
        {
            return age;
        }



    }
}
