using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Filters
{
    class Program
    {
        public static void salaryCal()
        {
            try
            {

                decimal var1 , tax, totaltax ,salary;
                Console.WriteLine("Inter the total salary befot cut tax ");
                var1 = Convert.ToDecimal(Console.ReadLine());
                if (var1 < 501)
                {
                    throw new Exception("Salary Less than $500");
                }
                Console.WriteLine("Inter the tax");
                tax = Convert.ToDecimal(Console.ReadLine());
                if(tax == 0)
                {
                    throw new Exception("the must not be a zero");
                }

                totaltax = var1 * tax;
                salary = var1 -totaltax;
                Console.WriteLine("the total tax will be {0} and the salary will be {1}" ,totaltax, salary);
            }
            catch (FormatException ex)
            {
                throw new Exception("salary format or tax is not mathc", ex.InnerException);
            }

        }
        static void Main(string[] args)
        {
            try
            {
                salaryCal();
            }

            catch (Exception MyEx) when (MyEx.Message.Equals("Salary Less than $500"))
            {
                Console.WriteLine("this has salary no taxs");
            }
            catch (Exception MyEx) when (MyEx.Message.Equals("the must not be a zero"))
            {
                Console.WriteLine("you entered a zero value for tax");
            }
            catch (Exception MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }


            Console.ReadKey();
        }
    }
}
