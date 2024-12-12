using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConstantly : MonoBehaviour
{
    public float moveSpeed;
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        rb.velocity = moveSpeed * Time.deltaTime * transform.right;
    }
}