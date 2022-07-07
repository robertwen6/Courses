using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);

            //try
            //{
            //    uint y = checked(x + 1);
            //    Console.WriteLine(y);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("There's overflow!");
            //}

            checked
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("There's overflow!");
                }
            }
        }
    }
}
