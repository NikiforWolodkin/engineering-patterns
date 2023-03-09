using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class FactoryL1 : IFactory
    {
        public IBonus GetA(float costOneHour)
        {
            return new BonusCalculatorL1A(costOneHour);
        }

        public IBonus GetB(float costOneHour, float x)
        {
            return new BonusCalculatorL1B(costOneHour, x);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new BonusCalculatorL1C(costOneHour, x, y);
        }
    }
}
