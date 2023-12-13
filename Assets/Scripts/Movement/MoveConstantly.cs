using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConstantly : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        rb.velocity = transform.right * moveSpeed * Time.deltaTime;
    }
}
