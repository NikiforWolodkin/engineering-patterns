using System;
using Lec03BLibN;

namespace Lab_3
{
    public class Employee
    {
        public IBonus Bonus { get; private set; }

        public Employee(IBonus bonus)
        {
            Bonus = bonus;
        }

        public float CalculateBonus(float numberOfHours)
        {
            return Bonus.Calculate(numberOfHours);
        }
    }
}
