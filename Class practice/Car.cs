using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Car : Vehicle
    {
        public string color;
        public int fuelCapacity;
        public byte doorCount;
        public int consumption;

        public static void gedilenyol(int fuelCapacity, int consumption)
        {
            int yol = 0;
            yol = fuelCapacity / consumption;
            Console.WriteLine(yol);
        }
    }
}
