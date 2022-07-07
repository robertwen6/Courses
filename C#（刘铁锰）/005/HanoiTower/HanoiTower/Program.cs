using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.move(3, 'a', 'b', 'c');
            c.SumOutput();
        }
    }

    public class Calculator
    {
        private int sum = 0;
        public void move(int n, char a, char b, char c)
        {
            if(n == 0)
            {
                return;
            }
            else
            {
                move(n - 1, a, c, b);
                Console.WriteLine(a + "->" + c);
                sum++;
                move(n - 1, b, a, c);
            }
        }

        public void SumOutput()
        {
            Console.WriteLine(sum);
        }
    }
}
