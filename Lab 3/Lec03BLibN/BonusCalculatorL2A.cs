using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL2A : IBonus
    {
        public float CostOneHour { get; set; }
        public float A { get; set; }

        public BonusCalculatorL2A(float costOneHour, float a)
        {
            CostOneHour = costOneHour;
            A = a;
        }

        public float Calculate(float numberOfHours)
        {
            return (numberOfHours + A) * CostOneHour;
        }
    }
}
