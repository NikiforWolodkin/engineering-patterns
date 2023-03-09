using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL3A : IBonus
    {
        public float CostOneHour { get; set; }
        public float A { get; set; }
        public float B { get; set; }

        public BonusCalculatorL3A(float costOneHour, float a, float b)
        {
            CostOneHour = costOneHour;
            A = a;
            B = b;
        }

        public float Calculate(float numberOfHours)
        {
            return (numberOfHours + A) * (CostOneHour + B);
        }
    }
}
