using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
   public  class Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("Patient : The billing has been checked ...");
        }

        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using string and integer");
        }
    }
}
