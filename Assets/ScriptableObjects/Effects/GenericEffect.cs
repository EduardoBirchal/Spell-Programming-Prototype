using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GenericEffect", menuName = "ScriptableObjects/Effects/GenericEffect")]
public class GenericEffect : GenericGlyph
{
    public float basePower, baseCost;
    
    protected Vector2 DirectionTo(Vector3 to, Vector3 from)
    {
        return (to - from).normalized;
    }
    public virtual void Activate(GameObject target, Vector3 location, float power, Vector2 direction = new Vector2()) {}
}