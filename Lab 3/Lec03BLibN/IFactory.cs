using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03BLibN
{
    public interface IFactory
    {
        IBonus GetA(float costOneHour);
        IBonus GetB(float costOneHour, float x);
        IBonus GetC(float costOneHour, float x, float y);
    }
}
