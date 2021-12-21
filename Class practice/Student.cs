using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Student : Person
    {
        public string study;

        public static void Study(string study)
        {
            Console.WriteLine("I am Studying");
        }

        public static void ShowAge(int age)
        {
            Console.WriteLine($"My age is :{age} years old ");
        }

        public string fullName;
        public byte course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;

        public Student(string fullName, string university)
        {
            this.fullName = fullName;
            this.university = university;

        }

        public void fullInfo(Student stu2)
        {
            Console.WriteLine($" name {stu2.fullName}," +
                $" course {stu2.course}," +
                $" faculty {stu2.subject} {stu2.university}." +
                $"  e-mail {stu2.email}, {stu2.phoneNumber}");
        }

    }
}
