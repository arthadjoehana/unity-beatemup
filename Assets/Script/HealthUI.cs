using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Slider _healthbar;
    [SerializeField] Image _healthfill;
   
    public void SetInitialHealth(int maxHealth)
    {
        _healthbar.maxValue = maxHealth;
        _healthbar.value = maxHealth;
    }

    public void UpdateHealth(int currentHealth)
    {
        _healthbar.value = currentHealth;
    }

}
