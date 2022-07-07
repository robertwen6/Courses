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
            Vehicle vehicle = new Car();
            vehicle.Run();
        }
    }

    interface IVehicle
    {
         void Stop();
         void Run();
    }

    abstract class Vehicle : IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
        abstract public void Run();
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running!");
        }
    }

    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running!");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Race car is running!");
        }
    }
}
