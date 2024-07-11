public interface IHealthHolder
{
    float HealthPoints { get; }
    void ChangeHealthPoints(float step);
}