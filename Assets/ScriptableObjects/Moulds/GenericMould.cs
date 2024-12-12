using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

[CreateAssetMenu(fileName = "GenericMould", menuName = "ScriptableObjects/Moulds/GenericMould")]
public class GenericMould : GenericGlyph
{
    public GameObject associatedObject;
    public float baseCost;
    public float baseMultiplier;

    protected virtual void ApplyModifiers(GameObject summonedObject, List<AssembledModifier> modifierList)
    {
        foreach (AssembledModifier currentModifier in modifierList)
        {
            summonedObject.AddComponent(currentModifier.GetType());
        }
    }

    public virtual void Create(GameObject caster, List<AssembledEffect> effectList, List<AssembledModifier> modifierList)
    {
        GameObject summonedObject = Instantiate(associatedObject, caster.transform.position, Quaternion.identity);
        MouldInfo mouldInfo = summonedObject.GetComponent<MouldInfo>();
        IEntity casterInfo = caster.GetComponent<IEntity>();

        mouldInfo.effectList = effectList;
        mouldInfo.caster = caster;
        mouldInfo.multiplier = baseMultiplier;
        
        foreach (AssembledModifier currentModifier in modifierList)
        {
            currentModifier.Apply(casterInfo, summonedObject);
        }
    }
}