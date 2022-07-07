using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(1, "Amy");
            stu.Report();
        }
    }

    class Student
    {
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        ~Student()
        {
            Console.WriteLine("Release!");
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{ID} stident, my name is {Name}.");
        }
    }
}
