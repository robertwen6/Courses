using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsClass);
            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
        }
    }
}
