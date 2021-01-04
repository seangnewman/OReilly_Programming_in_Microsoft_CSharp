using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been innoculated...");
        }
    }
}
