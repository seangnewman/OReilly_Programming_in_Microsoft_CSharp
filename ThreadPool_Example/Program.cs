using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Count);
            t.Start();

            // Tasks are automatically set to background
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("BG ");
                }
            });
        }

        private static void Count()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                Console.Write("FG ");
            }
        }
    }
}
