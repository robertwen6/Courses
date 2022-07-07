using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(int);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            int c = t.GetMethods().Length;
            foreach (var m in t.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine(c);
        }
    }
}
