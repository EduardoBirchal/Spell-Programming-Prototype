using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericGlyph", menuName = "ScriptableObjects/GenericGlyph")]
public class GenericGlyph : ScriptableObject
{
    public virtual float ManaCost { get; set; }

    public virtual float ApplyModifiers(List<GenericModifier> modifiers) {
        float newCost = ManaCost;

        if (modifiers != null) {
            foreach (GenericModifier modifier in modifiers) {
                newCost = modifier.ModifyCost(newCost);
            }
        }

        return newCost;
    }
}