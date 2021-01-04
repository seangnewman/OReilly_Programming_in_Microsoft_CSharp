using System;
using System.Collections.Generic;

namespace IEnumerable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            cars.Add("Chevrolet");
            cars.Add("Honda");
            cars.Add("Lexus");
            cars.Add("Ford");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


            Console.WriteLine("\n" + "Now our own collection ... " + "\n");
            Car c = new Car();
            c[0] = "Chevrolet";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            foreach (string car in c)
            {
                Console.WriteLine(car);
            }
        }
    }
}
