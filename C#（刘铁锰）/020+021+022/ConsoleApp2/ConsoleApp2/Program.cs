using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }

    class Controller
    {
        private Form Form;
        public Controller(Form form)
        {
            if(form != null)
            {
                this.Form = form;
                this.Form.Click += this.FormClicked;
            }
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.Form.Text = DateTime.Now.ToString();
        }
    }
}
