using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm1 = new Form(); 
            Form myForm2 = new Form();
            myForm1.Text = "My Form";
            myForm2.Text = myForm1.Text;
            myForm1.Text = "000";
            myForm2.ShowDialog();
        }
    }
}
