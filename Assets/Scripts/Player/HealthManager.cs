using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider slider;
    public PlayerStatsScriptableObject stats;

    // Start is called before the first frame update
    void Start()
    {
        stats.healthChangeEvent.AddListener(UpdateSlider);
        SetSlider();
    }

    void SetSlider()
    {
        slider.maxValue = stats.MaxHealth;
        slider.value = stats.CurrentHealth;
    }

    void UpdateSlider(int amount)
    {
        slider.value += amount;
    }
}
