using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

[CreateAssetMenu(fileName = "SelfMould", menuName = "ScriptableObjects/Moulds/SelfMould")]
public class SelfMould : GenericMould
{
    public override void Create(GameObject caster, List<AssembledEffect> effectList, List<AssembledModifier> modifierList)
    {
        foreach(AssembledEffect effect in effectList) {
            effect.Activate(caster, caster.transform.position, baseMultiplier);
        }
    }
}
