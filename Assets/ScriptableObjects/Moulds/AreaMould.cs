using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

[CreateAssetMenu(fileName = "AreaMould", menuName = "ScriptableObjects/Moulds/AreaMould")]
public class AreaMould : GenericMould
{
    public override void Create(GameObject caster, List<AssembledEffect> effectList, List<AssembledModifier> modifierList)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        GameObject summonedObject = Instantiate(associatedObject, new Vector3(mousePos.x, mousePos.y, -2), Quaternion.identity);
        MouldInfo mouldInfo = summonedObject.GetComponent<MouldInfo>();
        IEntity casterInfo = caster.GetComponent<IEntity>();

        mouldInfo.effectList = effectList;
        mouldInfo.caster = caster;
        mouldInfo.multiplier = baseMultiplier;

        Debug.Log("modifierList = " + modifierList);

        foreach (AssembledModifier currentModifier in modifierList)
        {
            currentModifier.Apply(casterInfo, summonedObject);
        }
    }
}