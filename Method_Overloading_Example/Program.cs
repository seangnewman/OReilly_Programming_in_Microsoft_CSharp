using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling();
            p.CheckBilling(3, 3);
            p.CheckBilling("Sean", 4);

            Child c = new Child();
            c.CheckBilling("Connor", "Cody");
        }
    }
}
