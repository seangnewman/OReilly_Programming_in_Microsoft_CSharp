using System.Collections;

namespace IEnumerable_Example
{
    class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var c in car)
            {
                yield return c;
            }
        }
    }
}
