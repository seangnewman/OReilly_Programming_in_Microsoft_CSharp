using System;

namespace Delegate_Example
{
    delegate int del(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //Sean s = new Sean();
            //Console.WriteLine(   s.AddNumbers(3, 3)) ;
            //Console.WriteLine(   s.MultiplyNumbers(4, 4));

            Sean s = new Sean();
            del d = s.AddNumbers;
            Console.WriteLine(d(3, 4));
            d = s.MultiplyNumbers;
            Console.WriteLine(d(3, 4));
            d = s.DoAnotherThing;
            Console.WriteLine(d(3, 4));
        }
    }
}
