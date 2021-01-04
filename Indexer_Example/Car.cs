using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Example
{
    public class Car
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >=0 && carNum < car.Length)
                {
                    return car[carNum];
                }
                return "Out of Index Range";
            }
            set
            {
                if(carNum >= 0 && carNum < car.Length)
                {
                    car[carNum] = value;
                }
            }
        }
    }
}
