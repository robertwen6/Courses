using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Age = 18;
            int[] array = new int[100];
            array[0] = 11;
        }
    }

    class Student
    {
        public static int Amount;
        public int Age;
        public string Name;
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
