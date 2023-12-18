using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoteMould", menuName = "ScriptableObjects/Moulds/MoteMould")]
public class MoteMould : ScriptableObject
{
    public float cost;

    public float CalculateCost(GenericEffect effect) {
        return cost + effect.CalculateCost();
    }
}