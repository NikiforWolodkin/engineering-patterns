using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class FactoryL3 : IFactory
    {
        public float A { get; set; }
        public float B { get; set; }

        public FactoryL3(float a, float b)
        {
            A = a;
            B = b;
        }

        public IBonus GetA(float costOneHour)
        {
            return new BonusCalculatorL3A(costOneHour, A, B);
        }

        public IBonus GetB(float costOneHour, float x)
        {
            return new BonusCalculatorL3B(costOneHour, A, B, x);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new BonusCalculatorL3C(costOneHour, A, B, x, y);
        }
    }
}
