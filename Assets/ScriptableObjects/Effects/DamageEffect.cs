using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageEffect", menuName = "ScriptableObjects/Effects/DamageEffect")]
public class DamageEffect : GenericEffect
{
    public override void Activate(GameObject target, Vector3 location, float power, Vector2 direction = new Vector2())
    {
        bool success = target.TryGetComponent<HpManager>(out HpManager hpManager);

        if (success) {
            hpManager.TakeDamage(power);
        }
    }
}