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
            Calculator c = new Calculator();
            int result = c.Add(1, 2);
            Console.WriteLine(result);
            string str = c.GetToday();
            Console.WriteLine(str);
            c.PrintSum(2, 7);
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetToday()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }

        public void PrintSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
