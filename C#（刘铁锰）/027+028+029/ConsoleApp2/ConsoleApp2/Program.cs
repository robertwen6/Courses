using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneUser phoneUser = new PhoneUser(new EricssonPhone());
            phoneUser.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone phone;
        public PhoneUser(IPhone phone)
        {
            this.phone = phone;
        }

        public void UsePhone()
        {
            phone.Dail();
            phone.PickUp();
            phone.Send();
            phone.Receive();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling!");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia ring!");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling!");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring!");
        }

        public void Send()
        {
            Console.WriteLine("Hi!");
        }
    }
}
