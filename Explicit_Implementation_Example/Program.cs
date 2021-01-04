using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Sean s = new Sean();
            s.DoThis();
            ((ISecond)s).DoThis();

            ISecond mm = new Sean();
            mm.DoThis();
        }
    }
}
