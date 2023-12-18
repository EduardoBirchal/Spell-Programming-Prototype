using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{
    public float currentHp;
    public float maxHp;

    void Start()
    {
        currentHp = maxHp;
    }

    public void ChangeHp (float amount) 
    {
        currentHp += amount;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);
    }

    public virtual void TakeDamage (float amount) 
    {
        ChangeHp (amount * -1);
    }

    public virtual void Heal (float amount) 
    {
        ChangeHp (amount);
    }
}
