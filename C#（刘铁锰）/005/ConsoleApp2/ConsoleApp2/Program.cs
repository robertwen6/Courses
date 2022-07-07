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
            c.PrintXTo1(8);
            c.AnothorPrintXTo1(4);
            c.GetSumFrom1ToX(100);
            Console.WriteLine(c.AnotherGetSumFrom1ToX(100)); 
        }
    }

    public class Calculator
    {
        public void PrintXTo1(int x)
        {
            for (int i = x; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void AnothorPrintXTo1(int x)
        {
            if(x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                AnothorPrintXTo1(x - 1);
            }
        }

        public void GetSumFrom1ToX(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public int AnotherGetSumFrom1ToX(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x + AnotherGetSumFrom1ToX(x - 1);
            }  
        }
    }
}
