using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageEffect", menuName = "ScriptableObjects/Effects/DamageEffect")]
public class DamageEffect : GenericEffect
{
    public override void Activate(GameObject target, float power)
    {
        bool success = target.TryGetComponent<HpManager>(out HpManager hpManager);

        if (success) {
            hpManager.TakeDamage(power);
        }
    }
}
