using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 0;
            try
            {
                Console.WriteLine("a divided by b is :" + a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The following error has occurred: " + e.Message);    
                 
            }
            finally
            {
                Console.WriteLine("finally has been called ..");
            }

            Console.WriteLine("The program continues .. ");
        }
    }
}
