using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHit : MonoBehaviour
{
    [SerializeField] private float damageAmount;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        switch (other.tag)
        {
            case "Enemy":
                other.GetComponent<EnemyHPManager>().TakeDamage(damageAmount);
                Destroy(gameObject);

                break;
        }
    }
}
