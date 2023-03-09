namespace Lec03BLibN
{
    public interface IBonus
    {
        float CostOneHour { get; set; }
        float Calculate(float numberOfHours);
    }
}