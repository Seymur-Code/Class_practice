using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public int dailySalary;

        public static int maash(int dailySalary, int day)
        {
            int monthSalary = dailySalary * day;
            Console.WriteLine($"Ayliq maaş {monthSalary}");
            return monthSalary;
        }
    }
}
