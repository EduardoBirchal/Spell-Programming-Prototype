using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

public class HandleContinuousCollision : HandleCollision
{
    protected override void Handle(Collider2D other)
    {
        foreach(AssembledEffect effect in mouldInfo.effectList) {
            effect.Activate(other.gameObject, transform.position, mouldInfo.multiplier * Time.deltaTime);
        }
    }
}