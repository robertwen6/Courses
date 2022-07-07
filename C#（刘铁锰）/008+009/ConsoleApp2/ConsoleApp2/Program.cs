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
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(1, 2));
        }
    }

    class Calculator
    {
        //重载
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add<T>(int a, int b)
        {
            return a + b;
        }

        public int Add(ref int a, int b)  //引用
        {
            return a + b;
        }
    }
}
