using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Person
    {
        public byte Age;
        public static void Greet()
        {
            Console.WriteLine("Yaşınız");
        }
        public static void SetAge(int Age)
        {
            Console.WriteLine(Age);
        }
    }
}
