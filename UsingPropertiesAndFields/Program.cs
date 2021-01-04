using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPropertiesAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 91;

            Console.WriteLine("Age: " + p.Age);
        }


    }
}
