using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("The constructor has been called ...");
            DoThat();
        }

        public void DoThat()
        {
            Console.WriteLine("DoThat has executed .. ");
        }
    }
}
