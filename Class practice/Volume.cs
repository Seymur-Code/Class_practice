using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Volume
    {
        public int width;
        public int length;
        public int height;


        public static int volumeMethod(int width, int lenght, int height)
        {
            int vol = width * lenght * height;

            Console.WriteLine($"width {width} , length {lenght}, height {height} volume {vol} ");
            return vol;
        }
    }
}
