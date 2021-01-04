using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void SlowDown()
        {
            Console.WriteLine("Car is slowing down...");
        }
    }
}
