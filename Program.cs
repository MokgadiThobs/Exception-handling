using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);


            }
            catch (Exception e)
            {  //can aslo have one generic error message, or catch the exact error.
                Console.WriteLine(e.Message);
            }
        }
    }
}
