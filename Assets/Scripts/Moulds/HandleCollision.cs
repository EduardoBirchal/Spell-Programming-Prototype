using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

public class HandleCollision : MonoBehaviour
{
    protected MouldInfo mouldInfo;
    protected Rigidbody2D rb;
    [SerializeField] private bool destroyOnHit;

    protected virtual void Start() {
        mouldInfo = GetComponent<MouldInfo>();
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void OnTriggerStay2D(Collider2D other) 
    {
        if (IsTargetable(other))
            Handle(other);
    }

    protected virtual bool IsTargetable(Collider2D other) 
    {
        return other.CompareTag("TargetableEntity") && (other.gameObject != mouldInfo.caster);
    }

    protected virtual void Handle(Collider2D other) 
    {
        foreach(AssembledEffect effect in mouldInfo.effectList) {
            effect.Activate(other.gameObject, transform.position, mouldInfo.multiplier, rb.velocity.normalized);
        }

        if (destroyOnHit)
            Destroy(gameObject);
    }
}
