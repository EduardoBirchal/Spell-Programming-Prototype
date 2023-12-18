using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHit : MonoBehaviour
{
    public GameObject caster;
    protected MouldInfo mouldInfo;

    protected void Start() {
        mouldInfo = GetComponent<MouldInfo>();
    }

    protected void OnTriggerEnter2D(Collider2D other) 
    {
        if (IsTargetable(other))
            Handle(other);
    }

    protected virtual bool IsTargetable(Collider2D other) 
    {
        return other.CompareTag("TargetableEntity") && other.gameObject != caster;
    }

    protected virtual void Handle(Collider2D other) 
    {
        mouldInfo.effect.Activate(other.gameObject, mouldInfo.effectPower);
    }
}
