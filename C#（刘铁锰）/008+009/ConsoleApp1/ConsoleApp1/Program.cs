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
            Student stu = new Student(2, "XiaoMing");
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
            Student stu2 = new Student();
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);
        }
    }

    class Student
    {
        public Student(int initId, string initName)
        {
            this.ID = initId;
            this.Name = initName;
        }

        public Student()
        {
            this.ID = 1;
            this.Name = "No name";
        }

        public int ID;
        public string Name;
    }
}
