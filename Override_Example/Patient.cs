using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Example
{
    public class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patient has been examined....");
        }

        
    }
}
