using UnityEngine;

public class HealthModifier : MonoBehaviour, IHealthModifier
{
    public float _healthStep = 5;

    public float HealthStep => _healthStep;
}