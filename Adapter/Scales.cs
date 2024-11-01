using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IScales
    {
        double GetWeight();
    }
    class RussianScales : IScales
    {
        private double _currentWeight;
        public RussianScales(double cw)
        {
            _currentWeight = cw;
        }
        public double GetWeight() => _currentWeight;
    }
    class BritishScales:IScales
    {
        private double _currentWeight;

        public BritishScales(double cw)
        {
            _currentWeight = cw;
        }

        public double GetWeight() => _currentWeight;
    }
    class AdapterBritishScales:IScales
    {
        private BritishScales? _britishScales;

        public AdapterBritishScales(BritishScales? britishScales)
        {
            _britishScales = britishScales;
        }

        public double GetWeight() => _britishScales!.GetWeight() * 0.453;
    }
    class AdapterRussianScales : IScales
    {
        private RussianScales? _russianScales;

        public AdapterRussianScales(RussianScales? russianScales)
        {
            _russianScales = russianScales;
        }

        public double GetWeight() => _russianScales!.GetWeight()/0.453;
    }
}
