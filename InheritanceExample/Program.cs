using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Sean");

            Child c = new Child();
            c.Examine("Cody");
            c.Inoculate();

            UnderFive uf = new UnderFive();
            uf.UnderFiveMethod();
        }
    }
}
