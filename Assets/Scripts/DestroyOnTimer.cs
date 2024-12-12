using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTimer : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    private float elapsedTime = 0;

    void Update()
    {
        Tick();
    }

    void Tick() {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= lifeTime) {
            Destroy(gameObject);
        }
    }
}
