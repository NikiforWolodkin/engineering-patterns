using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL1C : IBonus
    {
        public float CostOneHour { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public BonusCalculatorL1C(float costOneHour, float x, float y)
        {
            CostOneHour = costOneHour;
            X = x;
            Y = y;
        }

        public float Calculate(float numberOfHours)
        {
            return numberOfHours * CostOneHour * X + Y;
        }
    }
}
