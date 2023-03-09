using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    internal class BonusCalculatorL3C : IBonus
    {
        public float CostOneHour { get; set; }
        public float A { get; set; }
        public float B { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public BonusCalculatorL3C(float costOneHour, float a, float b, float x, float y)
        {
            CostOneHour = costOneHour;
            A = a;
            B = b;
            X = x;
            Y = y;
        }

        public float Calculate(float numberOfHours)
        {
            return (numberOfHours + A) * (CostOneHour + B) * X + Y;
        }
    }
}
