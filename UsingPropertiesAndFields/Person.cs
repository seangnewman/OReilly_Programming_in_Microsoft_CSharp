using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPropertiesAndFields
{
    class Person
    {


        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        private int age;
        public int Age
        {
            get { return age; }

            set
            {
                if ((value > 0) & (value < 65))
                { age = value; }
                else
                { throw new Exception("Age cannot be over 65 ..."); }

            }
        }
    }
}
