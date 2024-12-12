using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericModifier", menuName = "ScriptableObjects/Modifiers/GenericModifier")]
public class GenericModifier : ScriptableObject
{
    public float basePower, manaValue;
    public ModifierScript associatedScript;
    
    public virtual float ModifyCost(float baseCost) { return baseCost * manaValue; }
}