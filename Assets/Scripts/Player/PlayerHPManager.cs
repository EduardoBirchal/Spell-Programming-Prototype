using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpManager : HpManager
{
    [SerializeField] private Image healthBar;

    public override void TakeDamage(float amount) 
    {
        ChangeHp (amount * -1);
        UpdateHealthBar();
    }

    public override void Heal(float amount)
    {
        ChangeHp (amount);
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHp / maxHp;
    }
}
