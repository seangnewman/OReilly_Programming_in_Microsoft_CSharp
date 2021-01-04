using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_an_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine1 m1 = new Machine1();
            Machine2 m2 = new Machine2();
            Machine3 m3 = new Machine3();
            m1.Start();
            m1.Stop();

            m2.Start();
            m2.Stop();

            m3.Start();
            m3.Stop();
        }
    }
}
