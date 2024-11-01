using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IDeveloper developer;
        public Director(IDeveloper _developer) => developer = _developer;
        public void SetDeveloper(IDeveloper _developer) => developer = _developer;
        public Phone MountOnlyPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            return developer.GetPhone();
        }
        public Phone MountFullPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            developer.SyttemInstall();
            return developer.GetPhone();
        }
    }
}
