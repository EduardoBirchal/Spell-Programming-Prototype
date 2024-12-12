using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.InteropServices;

public class HpManager : MonoBehaviour
{
    public float currentHp;
    public float maxHp;
    public TMP_Text dummyTest; // DEBUG
    private static readonly string dummyTestText = "Dummy HP: "; // DEBUG

    void Start()
    {
        currentHp = maxHp;
    }

    public void ChangeHp (float amount) 
    {
        currentHp += amount;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);

        if (dummyTest != null)
            dummyTest.text = dummyTestText + currentHp; // DEBUG
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