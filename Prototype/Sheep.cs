using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Sheep:IAnimal
    {
        private string? Name;
        public Sheep(){}
        private Sheep(Sheep donor) => this.Name = donor.Name;
        public void SetName(string name)=>this.Name = name;
        public string GetName() => Name!;
        public IAnimal Clone() => new Sheep(this);
    }
}
