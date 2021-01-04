using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndConvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 2147483647;
            //long bigNum = num;

            //int i = 5;
            //double d = 10.5;

            //i = (int)d;
            //Console.WriteLine("The double variable d converted to int :" + i);

            int x = 7;
            double y = 12.6;

            x =(int) y;
            Console.WriteLine("Double casted to int: " + x);

            int xx = 7;
            double yy = 12.6;

            xx= Convert.ToInt32(yy);
            Console.WriteLine("Double Converted to int: " + xx);

            string str = "123";
            int r;
            r = Convert.ToInt32(str);
            Console.WriteLine("Using Convert to convert string to int:" + r);


        }
    }
}
