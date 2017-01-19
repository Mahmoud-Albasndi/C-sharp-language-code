using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString = null;
            Console.WriteLine($"{MyString}");
            int? MyInt = null;
            Console.WriteLine($"{MyInt}");
            bool? MyValue = null;
            Console.WriteLine($"{MyValue}");
            Console.ReadKey();
        }
    }
}
