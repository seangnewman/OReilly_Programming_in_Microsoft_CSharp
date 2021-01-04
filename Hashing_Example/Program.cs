using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to be hashed...");
            string pw = Console.ReadLine();
            Console.WriteLine();

            Hashing_Example.HashData hd = new Hashing_Example.HashData();
            Console.WriteLine(String.Format("The hash value for {0} is: ",pw));

            string pwh = hd.CreateHash(pw);
            Console.WriteLine(pwh);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("When the user logs in later, we'll get a password");
            Console.WriteLine("and compare it to the previous hash...");

            Console.WriteLine("Enter the original password: ");
            string pw2 = Console.ReadLine();
                       
            string pwh2 = hd.CreateHash(pw2);

            Console.WriteLine();
            Console.WriteLine("First hash : " + pwh);
            Console.WriteLine("Second hash: " + pwh2 );

            if (pwh == pwh2)
            {
                Console.WriteLine("File match.");
            }
            {
                Console.WriteLine("No match. ");
            }


        }
    }
}
