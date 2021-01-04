using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine();

            Adult a = new Adult();
            a.Examine();

            Patient pa = new Adult();
            pa.Examine();

        }
    }
}
