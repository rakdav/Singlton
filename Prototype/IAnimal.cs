using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
}
