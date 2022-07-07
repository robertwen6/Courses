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
            WarmKiller wk = new WarmKiller();
            wk.Love();
            IKiller killer = wk;
            killer.Kill();
        }
    }

    interface IGentleman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("Love");
        }

        void IKiller.Kill()
        {
            Console.WriteLine("Kill");
        }
    }
}
