using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Vehicle
    {
        public string brand;
        public string model;

        public static void arg(string model, string brand)
        {
            Console.WriteLine($"{model}   {brand}");
        }
    }
}
