using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 movementVector = new Vector2(GetHorizontalAxis(), GetVerticalAxis());
        rb.velocity = movementVector;

        animator.SetBool("IsMoving", movementVector.x != 0 || movementVector.y != 0);
    }

    float GetVerticalAxis() {
        float dir = Input.GetAxis ("Vertical");
        float movementAxis = dir * Time.deltaTime * moveSpeed;

        return movementAxis;
    }

    float GetHorizontalAxis() {
        float dir = Input.GetAxis("Horizontal");
        float movementAxis = dir * Time.deltaTime * moveSpeed;

        return movementAxis;
    }
}
