using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12345678;
            int y = ~x;
            string xStr = Convert.ToString(x, 2).PadLeft(32, '0');
            string yStr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(xStr);
            Console.WriteLine(yStr);
            int z = int.MinValue;
            Console.WriteLine(z);
        }
    }
}
