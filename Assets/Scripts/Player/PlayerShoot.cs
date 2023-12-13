using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 mousePos;
    private bool isLoaded = true;
    private float reloadTimer = 0f;

    [SerializeField] private float reloadDuration;
    [SerializeField] private GameObject bulletPrefab;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        if (isLoaded) {
            if(Input.GetMouseButton(0) && !PauseManager.isPaused) CreateBullet();
        }
        else {
            ReloadBullet();
        }
    }

    void CreateBullet() 
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;

        float rotationDegrees = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, rotationDegrees));

        isLoaded = false;
    }

    void ReloadBullet() {
        reloadTimer += Time.deltaTime;

        if (reloadTimer >= reloadDuration) {
            isLoaded = true;
            reloadTimer = 0f;
        }
    }
}
