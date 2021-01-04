using System;

namespace MulticastDelegate_Example
{
    class Program
    {

        delegate void del(int x, int y);
        static void Main(string[] args)
        {
            //Sean s = new Sean();
            //s.AddNumbers(5, 5);
            //s.MultiplyNumbers(6, 6);
            //s.SubtractNumbers(4, 7);

            Sean s = new Sean();
            del d;
            Console.WriteLine("Invoiking delegate d to add numbers");
            d = s.AddNumbers;
            d(7, 7);

            Console.WriteLine("Invoiking delegate d add target  multiply numbers");
            d += s.MultiplyNumbers;
            d(5, 5);

            Console.WriteLine("Invoiking delegate d to add target subtract numbers");
            d += s.SubtractNumbers;
            d(13, 10);

            Console.WriteLine("Invoiking delegate d to remove target multiply numbers");

            d -= s.MultiplyNumbers;
            d(13, 10);



        }
    }
}
