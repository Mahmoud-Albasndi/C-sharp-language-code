using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Mahmuoud Albasndi";
            int age = 24;
            Pirson MyObj = new Pirson();
            MyObj.SetName(Name);
            MyObj.SetAge(age);

            Console.WriteLine("This is Name  " + MyObj.GetName());
            Console.WriteLine("This is My Age  " + MyObj.GetAge());
            Console.ReadKey();
        }
    }
}
