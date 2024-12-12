using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PullEffect", menuName = "ScriptableObjects/Effects/PullEffect")]
public class PullEffect : GenericEffect
{
    public override void Activate(GameObject target, Vector3 location, float power, Vector2 direction = new Vector2())
    {
        bool success = target.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb);

        if (success) {
            if (direction.x == 0 && direction.y == 0)
                direction = (location - target.transform.position).normalized;

            rb.AddForce(direction * power, ForceMode2D.Impulse);
        }
    }
}