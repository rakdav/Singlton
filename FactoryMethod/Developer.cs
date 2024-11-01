using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string n)
        {
            Name = n;
        }
        abstract public House Create();
    }
    abstract class House() { }
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n){}
        public override House Create()
        {
            return new PanelHouse();
        }
    }

    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n){}
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
