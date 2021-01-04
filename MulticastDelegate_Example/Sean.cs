using System;

namespace MulticastDelegate_Example
{
    public class Sean
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(String.Format("AddNumbers a + b = {0}", a + b));
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(String.Format("MultiplyNumbers a * b = {0}", a * b));
        }

        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(String.Format("SubtractNumbers a + b = {0}", a - b));
        }

    }
}
