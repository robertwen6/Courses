using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Div(3, 0);
            Console.WriteLine(result);
        }
    }
}
