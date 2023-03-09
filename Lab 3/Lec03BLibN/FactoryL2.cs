using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class FactoryL2 : IFactory
    {
        public float A { get; set; }

        public FactoryL2(float a)
        {
            A = a;
        }

        public IBonus GetA(float costOneHour)
        {
            return new BonusCalculatorL2A(costOneHour, A);
        }

        public IBonus GetB(float costOneHour, float x)
        {
            return new BonusCalculatorL2B(costOneHour, A, x);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new BonusCalculatorL2C(costOneHour, A, x, y);
        }
    }
}
