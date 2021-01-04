using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_And_Await_Example
{
    class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await Task.Run(() => {
                CountToFifty()  ; 
            });

            //Will not execute until count to 50 is completed
            Console.WriteLine("Counting to 50 is completed...");
        }

        private  async Task<string> CountToFifty()
        {
            int counter;
            for ( counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("BG thread: " + counter);
            }
            return String.Format("Counter = {0}", counter);
        }
    }
}
