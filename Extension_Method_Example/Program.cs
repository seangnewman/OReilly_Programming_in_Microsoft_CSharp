using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = "hello";
            Console.WriteLine(x + "  is capitalized? " + x.IsCap());
            Console.WriteLine(y + "  is capitalized? " + y.IsCap());


        }
    }
}
