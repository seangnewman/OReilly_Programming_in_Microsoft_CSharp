using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Example
{
    public struct  Sean
    {
        public int x ;
        public int y;

        public Sean(int a, int b)
        {
            x = a;
            y = b;
        }

        public void DoThis()
        {
           
            Console.WriteLine(x + y );
        }

    }
}
