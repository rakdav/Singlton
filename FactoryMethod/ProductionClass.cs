using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    interface IProduction
    {
        void Release();
    }
    class Car : IProduction
    {
        public void Release()
        {
            Console.WriteLine("Car");
        }
    }
    class Truck : IProduction
    {
        public void Release() => Console.WriteLine("Truck");
    }
    interface IWorkShop
    {
        IProduction Create();
    }
    class CarWorkShop : IWorkShop
    {
        public IProduction Create() => new Car();
    }
    class TruckWorkShop : IWorkShop
    {
        public IProduction Create() => new Truck();
    }
}
