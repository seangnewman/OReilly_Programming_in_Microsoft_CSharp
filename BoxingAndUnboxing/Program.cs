using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int x = 25;

            o = x; //Boxing is taking place
            Console.WriteLine("o = " + o);
            Console.WriteLine("x = " + x);

            o = 123;
            x = (int)o;  // Unboxing taking place
            Console.WriteLine("o = " + o);
            Console.WriteLine("x = " + x);
        }
    }
}
