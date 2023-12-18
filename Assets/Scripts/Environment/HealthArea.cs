using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthArea : MonoBehaviour
{
    public float healthAmount;
    public bool isDamaging;

    void OnTriggerStay2D (Collider2D other) 
    {
        if (other.CompareTag("TargetableEntity")) {
            HpManager hpManager = other.GetComponent<HpManager>();

            if (isDamaging) 
                hpManager.TakeDamage(healthAmount * Time.deltaTime);
            else 
                hpManager.Heal(healthAmount * Time.deltaTime);
        }
    }
}
