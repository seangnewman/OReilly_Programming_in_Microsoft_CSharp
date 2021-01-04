using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pname)
        {
            Console.WriteLine("Examination of " + pname + " completed");

         }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed....");
        }
    }
}
