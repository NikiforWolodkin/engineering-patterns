using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL2C : IBonus
    {
        public float CostOneHour { get; set; }
        public float A { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public BonusCalculatorL2C(float costOneHour, float a, float x, float y)
        {
            CostOneHour = costOneHour;
            A = a;
            X = x;
            Y = y;
        }

        public float Calculate(float numberOfHours)
        {
            return (numberOfHours + A) * CostOneHour * X + Y;
        }
    }
}
