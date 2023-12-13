using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPManager : MonoBehaviour
{
    public float currentHp;
    public float maxHp;
    [SerializeField] private Image healthBar;

    void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(float amount) 
    {
        currentHp -= amount;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);

        UpdateHealthBar();
    }

    public void Heal(float amount)
    {
        currentHp += amount;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);

        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHp / maxHp;
    }
}
