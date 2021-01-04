using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation_Example
{
    class Sean : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis...");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis...");
            return 24;
        }

        public void Test()
        {

        }
    }
}
