using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type
{
    delegate int MyNewNumber(int MyNumber);
    class Program
    { 
        static int MyXnumber = 3;
        static int addFunct (int Number )
        {
            MyXnumber += Number;
            return MyXnumber;
        }
        static int mulfunc(int number)
        {
            MyXnumber *= number;
            return MyXnumber;
        }
        static void Main(string[] args)
        {
            MyNewNumber n1 = new MyNewNumber(addFunct);
            MyNewNumber n2 = new MyNewNumber(mulfunc);
            n1(5);
            Console.Write($"{MyXnumber}\n");
            n2(2);
            Console.WriteLine($"{MyXnumber}");
            Console.ReadKey();
        }
    }
}
