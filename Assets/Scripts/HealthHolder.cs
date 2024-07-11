using UnityEngine;

public class HealthHolder : MonoBehaviour, IHealthHolder
{
    public float HealthPoints { get; private set; } = 20f;

    public void ChangeHealthPoints(float step)
    {
        HealthPoints += step;
        if (HealthPoints < 0)
        {
            HealthPoints = 0;
        }
    }
}