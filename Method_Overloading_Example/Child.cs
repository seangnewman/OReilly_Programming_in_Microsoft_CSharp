using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
    public class Child :Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child : Billing has been checked using two strings");
        }
    }
}
