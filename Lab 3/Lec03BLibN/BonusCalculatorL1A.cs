using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL1A : IBonus
    {
        public float CostOneHour { get; set; }

        public BonusCalculatorL1A(float costOneHour)
        {
            CostOneHour = costOneHour;
        }

        public float Calculate(float numberOfHours)
        {
            return numberOfHours * CostOneHour;
        }
    }
}
