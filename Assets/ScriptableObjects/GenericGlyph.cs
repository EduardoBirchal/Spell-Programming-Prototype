using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericGlyph", menuName = "ScriptableObjects/GenericGlyph")]
public class GenericGlyph : ScriptableObject
{
    public float manaCost;

    public virtual float CalculateCost() { return manaCost; }

    public virtual float ApplyModifiers(List<GenericModifier> modifiers) {
        float newCost = manaCost;

        if (modifiers != null) {
            foreach (GenericModifier modifier in modifiers) {
                newCost = modifier.ModifyCost(newCost);
            }
        }

        return newCost;
    }
}