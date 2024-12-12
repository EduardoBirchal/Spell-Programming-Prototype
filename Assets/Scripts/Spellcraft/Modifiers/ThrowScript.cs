using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : ModifierScript
{
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.rotation = casterInfo.GetRotation();
    }

    void FixedUpdate()
    {
        rb.velocity = power * Time.deltaTime * transform.right;
    }
}