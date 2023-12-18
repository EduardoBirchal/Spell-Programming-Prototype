using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericEffect", menuName = "ScriptableObjects/Effects/GenericEffect")]
public class GenericEffect : GenericGlyph
{
    public float basePower;
    
    public virtual void Activate(GameObject target, float power) {}

    public virtual void ApplyAmplifications(float amount) { 
        basePower *= (amount+2)/2; 
        manaCost *= (amount+2)/2;
    }

    public virtual void ApplyDampenings(float amount) { 
        basePower /= (amount+2)/2; 
        manaCost /= (amount+2)/2; 
    }

    public override float CalculateCost() { return manaCost; }
}