using System;
namespace Async_And_Await_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the Main Thread .......");
            }

        }
    }
}
