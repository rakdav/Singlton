using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IDeveloper
    {
        void CreateDisplay();
        void CreateBox();
        void SyttemInstall();
        Phone GetPhone();
    }
}
