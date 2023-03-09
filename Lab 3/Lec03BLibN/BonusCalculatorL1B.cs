using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL1B : IBonus
    {
        public float CostOneHour { get; set; }
        public float X { get; set; }

        public BonusCalculatorL1B(float costOneHour, float x)
        {
            CostOneHour = costOneHour;
            X = x;
        }

        public float Calculate(float numberOfHours)
        {
            return numberOfHours * CostOneHour * X;
        }
    }
}
