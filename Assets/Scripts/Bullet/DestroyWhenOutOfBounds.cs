using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Screen Limit"))
            Destroy(gameObject);
    }
}
