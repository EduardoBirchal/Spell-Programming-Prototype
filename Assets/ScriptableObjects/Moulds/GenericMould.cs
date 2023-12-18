using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericMould", menuName = "ScriptableObjects/Moulds/GenericMould")]
public class GenericMould : GenericGlyph
{
    public float CalculateCost(GenericEffect effect) {
        return manaCost + effect.CalculateCost();
    }
}