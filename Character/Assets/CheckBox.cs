using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    public TMP_Text hp;
    public GameObject hint;
    private IHealthHolder healthHolder;
    private IHealthModifier healthModifier;
    void Start()
    {
        healthHolder = gameObject.GetComponent<IHealthHolder>();
    }

    void OnGUI()
    {
        if (healthModifier != null & Event.current.Equals(Event.KeyboardEvent(KeyCode.E.ToString())))
        {
            healthHolder.ChangeHealthPoints(healthModifier.HealthStep);
            hp.text = healthHolder.HealthPoints.ToString();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        var hm = col.GetComponent<IHealthModifier>();
        if (hm != null)
        {
            healthModifier = hm;
            Interact(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        var hm = col.GetComponent<IHealthModifier>();
        if (hm != null)
        {
            healthModifier = null;
            Interact(false);
        }
    }

    void Interact(bool active)
    {
        hint.SetActive(active);
    }
}
