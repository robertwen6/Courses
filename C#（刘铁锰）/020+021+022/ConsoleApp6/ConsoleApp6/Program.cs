using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    //public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    public class Customer
    {
        public event EventHandler Order;
        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay {0}.", this.Bill);
        }

        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant.");
        }

        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think...");
                Thread.Sleep(1000);
            }

            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.Order.Invoke(this, e);
            }
        }

        public void Action()
        {
            this.WalkIn();
            this.SitDown();
            this.Think();

        }
    }

    public class Waiter
    {
        public void Action(object sender, EventArgs e)
        {
            Customer customer = sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;
            Console.WriteLine("I will serve you the dish {0}", orderInfo.DishName);
            double price = 10;
            switch (orderInfo.Size)
            {
                case "small":
                    price *= 0.5;
                    break;
                case "large":
                    price *= 1.5;
                    break;
                default:
                    break;
            }

            customer.Bill += price;
        }
    }
}
