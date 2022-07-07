using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine(x);
            int y = x ?? 1;
            Console.WriteLine(y);
        }
    }
}
