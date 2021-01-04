using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Example
{
    public class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The Adult has been examined....");
        }
    }
}
