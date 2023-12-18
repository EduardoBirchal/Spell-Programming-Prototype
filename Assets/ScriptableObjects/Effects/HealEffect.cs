using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealEffect", menuName = "ScriptableObjects/Effects/HealEffect")]
public class HealEffect : GenericEffect
{
    public override void Activate(GameObject target, float power)
    {
        bool success = target.TryGetComponent<HpManager>(out HpManager hpManager);

        if (success) {
            hpManager.Heal(power);
        }
    }
}
