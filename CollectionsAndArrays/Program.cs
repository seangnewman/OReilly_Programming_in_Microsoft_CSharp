using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection that is a list of strings
            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Malamute");

            // for each to move through list
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + " ");
            //}

            //Create an array of integers
            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };
            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
