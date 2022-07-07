using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            CsStudent csStu = new CsStudent();
            stu.Report();
            csStu.Report();
        }

        class Student
        {
            public void Report()
            {
                Console.WriteLine("I'm a student.");
            }
        }

        class CsStudent : Student
        {
            new public void Report()
            {
                Console.WriteLine("I'm a CS student");
            }
        }
    }
}
