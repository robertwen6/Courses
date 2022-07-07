using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();
            Console.WriteLine(v.Speed);
        }
    }

    class Vehicle
    {
        private int speed;
        public virtual int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public virtual void Run()
        {
            Console.WriteLine("A is running!");
            speed = 100;
        }
    }

    class Car : Vehicle
    {
        private int rpm;
        public override int Speed
        {
            get
            {
                return rpm / 100;
            }
            set
            {
                rpm = value * 100;
            }
        }
        public override void Run()
        {
            Console.WriteLine("B is running!");
            rpm = 5000;
        }
    }

    class RaseCar : Car
    {
        public void Run()
        {
            Console.WriteLine("C is running!");
        }
    }
}
