using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = "Dodge";
            c[3] = "Chevrolet";
            c[4] = "Honda";

            Console.WriteLine("Car 1 is : "  + c[1]);
            Console.WriteLine("Car 2 is : " + c[2]);
            Console.WriteLine("Car 4 is : " + c[4]);
        }
    }
}
